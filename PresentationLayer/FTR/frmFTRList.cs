using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using CashFlow.BusinessLayer;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.GroupingGridExcelConverter;
using Excel = Microsoft.Office.Interop.Excel;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.PivotConverter;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.Data;

namespace CashFlow.PresentationLayer.Cash_Flow 
{
    public partial class frmFTRList : Office2010Form
    {
        ClassFTR FTR = new ClassFTR();
        int loginUserRoleID = CashFlowGlobalVariables.GlobalVariables.RoleID;
        string loginUser = CashFlowGlobalVariables.GlobalVariables.UserID;
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
         
        List<FTRHeaderList> ftrList = new List<FTRHeaderList>();

        public static List<string> MonthsFull = new List<string>
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public frmFTRList()
        {
            InitializeComponent();
        }

        private void ResetAll()
        {
            panelNewFTR.Visible = false;
            lblProjectName.Visible = false;
            cmbProjectName.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            cmbProjectName.Text = "Select Project";
            if (loginUserRoleID == 2)
                btnNew.Visible = true;
            else
                btnNew.Visible = false;

            this.gridFTRHistory.ThemeName = "Office2016DarkGray";

            lblConfirm.Visible = false;
            txtConfirm.Visible = false;
        }

        private void LoadProjects()
        {
            DataSet ds = FTR.GetProjectsForFTR(loginUser);
            cmbProjectName.DataSource = ds.Tables[0];
            cmbProjectName.Refresh();
            int noProjects = ds.Tables[0].Rows.Count;
            if (noProjects >= 1)
               btnNew.Enabled = true;
           else
               btnNew.Enabled = false;
        }

        private void frmFTRSubbie_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadProjects();
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((cmbCalMonth.Text == "Select Month") || (cmbCalYear.Text == "Select Year"))
                return;

            btnSubmit.Enabled = false;
            lblConfirm.Visible = true;
            txtConfirm.Visible = true;
            txtConfirm.Text = "NO";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelNewFTR.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panelNewFTR.Visible = true;
            lblProjectName.Visible = true;
            cmbProjectName.Visible = true;
            cmbProjectName.Text = "Select Project";
            lblCalendarMonth.Visible = false;
            lblCalendarYear.Visible = false;
            cmbCalYear.Visible = false;
            cmbCalMonth.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = true;
            btnGO.Visible = true;
            btnGO.Enabled = true;
        }



     

        private void LoadGrid()
        {
            DataSet dsFTRHistory = FTR.GetFTRHistory(loginUser);
            if (dsFTRHistory.Tables[0].Rows.Count == 0)
                btnNew.Visible = true;
            ftrList =Utility.CreateListFromTable<FTRHeaderList>(dsFTRHistory.Tables[0]);
            gridFTRHistory.DataSource = ftrList;
            
            gridFTRHistory.Columns["FOREDIT"].AllowFiltering = false;
            gridFTRHistory.Columns["FOREXPORT"].AllowFiltering = false;
            gridFTRHistory.Columns["FORPRINT"].AllowFiltering = false;
            this.gridFTRHistory.ThemeName = "Office2016DarkGray";
            this.gridFTRHistory.SelectionMode = GridSelectionMode.Single;
            gridFTRHistory.Refresh();

        }


        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text.ToUpper()=="YES")
            { 
                if (cmbProjectName.Text == "Select Project")
                {
                    MessageBox.Show("Select Project !!");
                    return;
                }
                int projectID = Convert.ToInt16(cmbProjectName.SelectedValue);
                int calYear = Convert.ToInt16(cmbCalYear.SelectedValue);
                int calMonth = Convert.ToInt16(cmbCalMonth.SelectedValue);
                string owner = CashFlowGlobalVariables.GlobalVariables.UserID;
                int i = FTR.GenerateFTRHeader(projectID,calYear,calMonth,owner);
                DataSet ds = FTR.GetFTRID(projectID);
                int lastFTRID = Convert.ToInt16(ds.Tables[0].Rows[0]["FTRID"]);
                int k = FTR.UpdateFTRLog(lastFTRID, owner);
                panelNewFTR.Visible = false;
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;
                txtConfirm.Text = "No";
                cmbCalMonth.Text = "Select Month";
                cmbCalYear.Text = "Select Year";
                LoadProjects();
                LoadGrid();
            }

        }

        private void panelNewFTR_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void gridFTRHistory_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
            this.gridFTRHistory.Style.SelectionStyle.BackColor = Color.LightSeaGreen;
            this.gridFTRHistory.Style.SelectionStyle.TextColor = Color.DarkBlue;

            int rowindex = gridFTRHistory.TableControl.ResolveToRecordIndex(gridFTRHistory.CurrentCell.RowIndex);
            var record = this.gridFTRHistory.View.Records.GetItemAt(rowindex);
            string ftrIDString = record.GetType().GetProperty("FTRID").GetValue(record).ToString();
            string buttonExportHeaderText = record.GetType().GetProperty("FOREXPORT").GetValue(record).ToString();
            string buttonPrintHeaderText = record.GetType().GetProperty("FORPRINT").GetValue(record).ToString();
            string buttonEditHeaderText = record.GetType().GetProperty("FOREDIT").GetValue(record).ToString();

      
            int ftrID  = Convert.ToInt16(ftrIDString);

            int clickedColumn = e.ColumnIndex;

            //  Column 9 is For Edit  Column 10 For Export and Column 11 is ForPrint 

            string headerText = Convert.ToString(e.Column.HeaderText);
        
            if (  (buttonEditHeaderText == "Open") && (clickedColumn==9) )
            {
                MessageBox.Show(" Please  Relax ... Loading The Work Sheet   !!!!!");
                frmFTRWorkSheet ftrWS = new frmFTRWorkSheet(ftrID);
                ftrWS.ShowDialog();
                gridFTRHistory.DataSource = null;
                LoadGrid();
            }

            if ( (buttonExportHeaderText == "Excel") && (clickedColumn ==10) ) 
            {
                frmFTRExcel ftrExcel = new frmFTRExcel(ftrID);
                ftrExcel.ShowDialog();
                
            }

            
        }

        private void gridFTRHistory_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Open")
            {
                e.Column.HeaderStyle.BackColor = Color.LightSkyBlue;
                e.Column.CellStyle.BackColor = Color.MediumBlue;
            }

            if (e.Column.MappingName == "Print")
            {
                e.Column.HeaderStyle.BackColor = Color.LightPink;
                e.Column.CellStyle.BackColor = Color.LightSlateGray; ;
                
            }

        }

        private void gridFTRHistory_QueryButtonCellStyle(object sender, QueryButtonCellStyleEventArgs e)
        {
            if ((e.Record as FTRHeaderList).FOREDIT == "Restricted")
                e.Button.Style.Enabled = false;
            if ((e.Record as FTRHeaderList).FORPRINT == "Print")
                e.Button.Style.Enabled = true;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            btnGO.Enabled = false;
            int projID = Convert.ToInt16(cmbProjectName.SelectedValue);
            DataSet dsCaledarYearDetails = FTR.FetchDetailsForNewFTR(projID);
            
             
            cmbCalYear.DataSource = dsCaledarYearDetails.Tables[0];
            cmbCalMonth.DataSource = dsCaledarYearDetails.Tables[1];
          
            cmbCalMonth.Visible = true;
            cmbCalYear.Visible = true;
            lblCalendarMonth.Visible = true;
            lblCalendarYear.Visible = true;
            btnSubmit.Visible = true;
            btnSubmit.Enabled = true;
        }

        private void gridFTRHistory_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }
    }
}
