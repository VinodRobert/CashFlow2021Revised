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
            if (loginUserRoleID == 1)
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
            btnSubmit.Visible = true;
            btnCancel.Visible = true;
            cmbProjectName.Text = "Select Project";
        }

        private void LoadGrid()
        {
            DataSet dsFTRHistory = FTR.GetFTRHistory(loginUser);
      
          
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
                int i = FTR.GenerateFTRHeader(projectID);
                panelNewFTR.Visible = false;
                LoadProjects();
                LoadGrid();
            }

        }

        private void panelNewFTR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridFTRHistory_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;

        }

        private void gridFTRHistory_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
            this.gridFTRHistory.Style.SelectionStyle.BackColor = Color.LightSeaGreen;
            this.gridFTRHistory.Style.SelectionStyle.TextColor = Color.DarkBlue;

            int rowindex = gridFTRHistory.TableControl.ResolveToRecordIndex(gridFTRHistory.CurrentCell.RowIndex);
            var record = this.gridFTRHistory.View.Records.GetItemAt(rowindex);
            string ftrIDString = record.GetType().GetProperty("FTRID").GetValue(record).ToString();
            string buttonHeaderText = Convert.ToString(e.Column.HeaderText);
            int ftrID  = Convert.ToInt16(ftrIDString);

           

        
            if (buttonHeaderText == "Open")
            {
                MessageBox.Show(" Please  Relax ... Loading The Work Sheet   !!!!!");
                frmFTRWorkSheet ftrWS = new frmFTRWorkSheet(ftrID);
                ftrWS.ShowDialog();
                gridFTRHistory.DataSource = null;
                LoadGrid();
            }

            if (buttonHeaderText == "Export")
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
                //  e.Column.HeaderStyle.BackColor = Color.LightPink;
                e.Column.CellStyle.BackColor = Color.LightPink;
                
            }

        }

        private void gridFTRHistory_QueryButtonCellStyle(object sender, QueryButtonCellStyleEventArgs e)
        {
            if ((e.Record as FTRHeaderList).FOREDIT == "Restricted")
                e.Button.Style.Enabled = false;
            if ((e.Record as FTRHeaderList).FORPRINT == "Print")
                e.Button.Style.Enabled = true;
        }
    }
}
