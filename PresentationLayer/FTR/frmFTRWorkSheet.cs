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
using System.Data.SqlClient;
using CashFlowSqlHelper;

namespace CashFlow.PresentationLayer.Cash_Flow 
{
    public partial class frmFTRWorkSheet : Office2010Form
    {
        ClassFTR FTR = new ClassFTR();
        DataSet dsResult;
        DataTable dsResultTable;
        int ftrIDToExtract;
        List<SingleFTR> singleFTRList = new List<SingleFTR>();
        int loginUserRoleID = CashFlowGlobalVariables.GlobalVariables.RoleID;
        DataTable dtRecommendations;
        DataTable dtFiltered;
     

        public frmFTRWorkSheet(int ftrID)
        {
            InitializeComponent();
            ftrIDToExtract = ftrID;
        }
   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayGrid()
        {
           
            gridResult.DataSource = dsResult.Tables[0];

            this.gridResult.AllowGrouping = true;
            this.gridResult.Columns["MAJORCATEGORY"].AllowGrouping = true;
            this.gridResult.Columns["MINORCATEGORY"].AllowGrouping = true;
            this.gridResult.Columns["CATEGORY"].AllowGrouping = true;
            this.gridResult.View.AutoExpandGroups = true;
            this.gridResult.GroupPanel.Margin = new Padding(12);
            this.gridResult.Style.GroupDropAreaStyle.BackColor = Color.LightSkyBlue;
            this.gridResult.Style.GroupDropAreaStyle.TextColor = Color.Red;
            this.gridResult.GroupPanel.GroupDropAreaText = "Drag columns here";
            this.gridResult.GroupCaptionTextFormat = "{Key} : {ItemsCount}";
            this.gridResult.Style.GroupDropAreaItemStyle.TextColor = Color.DarkBlue;
            this.gridResult.Style.GroupDropAreaItemStyle.BackColor = Color.LightSkyBlue;
            this.gridResult.FilterPopupMode = Syncfusion.WinForms.GridCommon.FilterPopupMode.Both;

            //Creating object for a stacked header row.
            var stackedHeaderRow1 = new StackedHeaderRow();

            //Adding stacked column to stacked columns collection available in stacked header row object.
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "MAJORCATEGORY,MINORCATEGORY,CATEGORY", HeaderText = "FTR Display Levels" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "VENDORTYPE,PARTYCODE,PARTYNAME,", HeaderText = "Vendor Deatils" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "NETPAYABLE,PAID,PROJECTLIABILITY", HeaderText = "Project Level Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "MOBADVANCE,GSTCREDIT,COMPANYLIABILITY,PAYABLEAFTERGST,PAYABLE", HeaderText = "Company Level Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "PROJECTSITE,PAYABLERECOMMENDED", HeaderText = "Payment Recommendations" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "ACCOUNTSHEAD,CONTROLCELL", HeaderText = "Approval" });

            //Adding stacked header row object to stacked header row collection available in SfDataGrid.
            gridResult.StackedHeaderRows.Add(stackedHeaderRow1);
            this.gridResult.Style.StackedHeaderStyle.BackColor = Color.DarkCyan;
            this.gridResult.Style.StackedHeaderStyle.TextColor = Color.White;

            this.gridResult.ThemeName = "Office2019Colorful";
            this.gridResult.FrozenColumnCount = 8;

            this.gridResult.Style.VerticalScrollBar.ArrowButtonForeColor = Color.Black;
            this.gridResult.Style.VerticalScrollBar.ArrowButtonHoverForeColor = Color.Black;
            this.gridResult.Style.VerticalScrollBar.ArrowButtonPressedForeColor = Color.Gray;
            this.gridResult.Style.VerticalScrollBar.ArrowButtonBorderColor = Color.Black;

            gridResult.Refresh();
            gridResult.Visible = true;

            lblProjectName.Text = Convert.ToString(dsResult.Tables[1].Rows[0]["BORGNAME"]);
            lblFTRNumber.Text = Convert.ToString(dsResult.Tables[1].Rows[0]["FTRNUMBER"]);

            this.gridResult.ToolTipOption.ToolTipMode = ToolTipMode.TrimmedCells;
            this.gridResult.Columns["PARTYNAME"].ShowToolTip = true;

            gridResult.Columns["PROJECTSITE"].AllowEditing = false;
            gridResult.Columns["PAYABLERECOMMENDED"].AllowEditing = false;
            gridResult.Columns["ACCOUNTSHEAD"].AllowEditing = false;
            gridResult.Columns["CONTROLCELL"].AllowEditing = false;


            gridResult.Columns["PAYABLERECOMMENDED"].Visible = false;
            gridResult.Columns["ACCOUNTSHEAD"].Visible = false;
            gridResult.Columns["CONTROLCELL"].Visible = false;


            if (loginUserRoleID == 1)
            {
                gridResult.Columns["PROJECTSITE"].AllowEditing = true;
                gridResult.Columns["PROJECTSITE"].Visible = true;
                gridResult.Columns["PAYABLERECOMMENDED"].AllowEditing = false;
                gridResult.Columns["PAYABLERECOMMENDED"].Visible = false;
                gridResult.Columns["ACCOUNTSHEAD"].AllowEditing = false;
                gridResult.Columns["ACCOUNTSHEAD"].Visible = false;
                gridResult.Columns["CONTROLCELL"].AllowEditing = false;
                gridResult.Columns["CONTROLCELL"].Visible = false;

            }

            if (loginUserRoleID == 2)
            {
                gridResult.Columns["PROJECTSITE"].AllowEditing = false;
                gridResult.Columns["PROJECTSITE"].Visible = true;
                gridResult.Columns["PAYABLERECOMMENDED"].AllowEditing = true;
                gridResult.Columns["PAYABLERECOMMENDED"].Visible = true;
                gridResult.Columns["ACCOUNTSHEAD"].AllowEditing = false;
                gridResult.Columns["ACCOUNTSHEAD"].Visible = false;
                gridResult.Columns["CONTROLCELL"].AllowEditing = false;
                gridResult.Columns["CONTROLCELL"].Visible = false;
            }

            if (loginUserRoleID==3)
            {
                gridResult.Columns["PROJECTSITE"].AllowEditing = false;
                gridResult.Columns["PROJECTSITE"].Visible = true;
                gridResult.Columns["PAYABLERECOMMENDED"].AllowEditing = true;
                gridResult.Columns["PAYABLERECOMMENDED"].Visible = true;
                gridResult.Columns["ACCOUNTSHEAD"].AllowEditing = true;
                gridResult.Columns["ACCOUNTSHEAD"].Visible = true;
                gridResult.Columns["CONTROLCELL"].AllowEditing = false;
                gridResult.Columns["CONTROLCELL"].Visible = false;
            }

            if (loginUserRoleID == 4)
            {
                gridResult.Columns["PROJECTSITE"].AllowEditing = false;
                gridResult.Columns["PROJECTSITE"].Visible = true;
                gridResult.Columns["PAYABLERECOMMENDED"].AllowEditing = true;
                gridResult.Columns["PAYABLERECOMMENDED"].Visible = true;
                gridResult.Columns["ACCOUNTSHEAD"].AllowEditing = false;
                gridResult.Columns["ACCOUNTSHEAD"].Visible = true;
                gridResult.Columns["CONTROLCELL"].AllowEditing = true;
                gridResult.Columns["CONTROLCELL"].Visible = true;
            }
        }

     

        private void gridResult_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void frmFTRWorkSheet_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            dsResult = FTR.GetFTRWorkSheet(ftrIDToExtract);
            dsResultTable = dsResult.Tables[0];
            singleFTRList = Utility.CreateListFromTable<SingleFTR>(dsResultTable);
            DisplayGrid();
        }

        private void gridResult_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            if (gridResult.CurrentCell.CellRenderer != null)
            {
                var currentCellValue = gridResult.CurrentCell.CellRenderer.GetControlValue();
                int columnIndex = gridResult.CurrentCell.ColumnIndex;
                var mappingName = gridResult.Columns[columnIndex].MappingName;
                var selectedItem = this.gridResult.CurrentItem as DataRowView;
                var dataRow = (selectedItem as DataRowView).Row;
                var cellValue = dataRow["RESULTID"].ToString();
                int resultID = Convert.ToInt16(cellValue);
                string searchExpression = "RESULTID=" + Convert.ToString(resultID);
                System.Data.DataRow[] rows = dsResultTable.Select(searchExpression);
                rows[0][mappingName] = currentCellValue;
                dsResultTable.AcceptChanges();
            }
        }

        public void SaveToTables()
        {
            string partyCode;
            int ftrID=0;
            decimal projectSite;
            decimal finalValue;
            bool head;
            bool controlCell;

            int row;
            int maxRowCount = dtFiltered.Rows.Count;

            System.Data.DataRow singlePartyApproval;

            dtRecommendations = new DataTable("Approvals");
            dtRecommendations.Columns.Add(new DataColumn("APPROVALID", typeof(int)));
            dtRecommendations.Columns.Add(new DataColumn("FTRID", typeof(int)));
            dtRecommendations.Columns.Add(new DataColumn("PARTYCODE", typeof(string)));
            dtRecommendations.Columns.Add(new DataColumn("PROJECTSITE", typeof(decimal)));
            dtRecommendations.Columns.Add(new DataColumn("FINALVALUE", typeof(decimal)));
            dtRecommendations.Columns.Add(new DataColumn("HEAD", typeof(bool)));
            dtRecommendations.Columns.Add(new DataColumn("CONTROLCELL", typeof(bool)));

            for (row = 0; row <= maxRowCount - 1; row++)
            {
                singlePartyApproval = dtFiltered.Rows[row];


                ftrID = Convert.ToInt16(singlePartyApproval["FTRID"]);
                partyCode = Convert.ToString(singlePartyApproval["PARTYCODE"]);
                projectSite = Convert.ToDecimal(singlePartyApproval["PROJECTSITE"]);
                finalValue = Convert.ToDecimal(singlePartyApproval["PAYABLERECOMMENDED"]);
                head = Convert.ToBoolean(singlePartyApproval["ACCOUNTSHEAD"]);
                controlCell = Convert.ToBoolean(singlePartyApproval["CONTROLCELL"]);
                dtRecommendations.Rows.Add(0,ftrID, partyCode, projectSite, finalValue,head,controlCell);

            }

            int deletes = FTR.DeleteExistingEntries(ftrID);

            try
            {
                string _connectionString = SqlHelper.GetConnectionString();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_connectionString))
                {
                    bulkCopy.BulkCopyTimeout = 600; // in seconds
                    bulkCopy.DestinationTableName = "[FTR].[FTRAMOUNTAPPROVED]";
                    bulkCopy.WriteToServer(dtRecommendations);
                 
                }
            }
            catch(Exception ex)
            {
                string errorMessage = "Failed To Save FTR Approval Tables " + ex.Message;
                MessageBox.Show(errorMessage, "Failed To Save ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;

            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string filterExpression = " ( (PROJECTSITE>0) OR (PAYABLERECOMMENDED>0) ) ";
            System.Data.DataRow[] filtered = dsResultTable.Select(filterExpression);

            if (filtered.Length > 0)
            {
                dtFiltered = filtered.CopyToDataTable();
                System.Data.DataColumn ftrColumn = new System.Data.DataColumn("FTRID", typeof(System.Int16));
                ftrColumn.DefaultValue = ftrIDToExtract;
                dtFiltered.Columns.Add(ftrColumn);
                dtFiltered.AcceptChanges();
            }
            SaveToTables();
            MessageBox.Show("Success !!!");
            btnSubmit.Enabled = true;
        }

        

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string message = "Are You Sure To Submit. Not Reversable  ??";
            string title = "Submission Approval";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int i = FTR.UpdateCustodian(ftrIDToExtract);
                MessageBox.Show("Success !!!");
                this.Close();
            }
            else
            {
                // Do something  
            }
        }
    }
}
