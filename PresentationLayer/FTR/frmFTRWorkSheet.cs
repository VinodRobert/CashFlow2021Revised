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
    public partial class frmFTRWorkSheet : Office2010Form
    {
        CashFlowBL CF = new CashFlowBL();
        string projectName;
        int currentFinYear, currentPeriod;
        DataSet dsResult;

        public frmFTRWorkSheet()
        {
            InitializeComponent();
        }
       
        private void ResetAll()
        {
             
            cmbProject.Text = "Select Project";
            chkReCreate.Checked = false;
            gridResult.Visible = false;
           
        }

        private void LoadProjects()
        {
            DataSet ds = CF.GetProjects();
            cmbProject.DataSource = ds.Tables[0];
            cmbProject.Refresh();
        }

        private void LoadFinYears()
        {
            DataSet dsFinYear = CF.GetFinYears();
            cmbFinYear.DataSource = dsFinYear.Tables[0];
            cmbFinYear.Refresh();
            cmbFinYear.SelectedValue = currentFinYear;
             
        }

        private void LoadPeriods()
        {
            DataSet dsPeriod = CF.GetPeriods();
            cmbPeriod.DataSource = dsPeriod.Tables[0];
            cmbPeriod.Refresh();
            cmbPeriod.SelectedValue = currentPeriod-1;

        }

        private void LoadCurrentFinYearAndPeriod()
        {
            DataSet dsCurrents = CF.GetCurrents();
            currentFinYear = Convert.ToInt16(dsCurrents.Tables[0].Rows[0]["CurrentFinYear"]);
            currentPeriod = Convert.ToInt16(dsCurrents.Tables[0].Rows[0]["CurrentPeriod"]);

            
        }
        private void frmFTRSubbie_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadCurrentFinYearAndPeriod();
            LoadProjects();
            LoadFinYears();
            LoadPeriods();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnView_Click(object sender, EventArgs e)
        {
            projectName = Convert.ToString(cmbProject.Text);
            if (projectName == "Select Project")
                return;
            
            int finYear;
            finYear = Convert.ToInt16(cmbFinYear.Text);

            int period;
            period = Convert.ToInt16(cmbPeriod.SelectedValue);

            int reCreate;
            if (chkReCreate.Checked == true)
                reCreate = 1;
            else
                reCreate = 0;

            cmbProject.Enabled = false;
            cmbPeriod.Enabled = false;
            cmbFinYear.Enabled = false;
            btnnView.Enabled = false;


            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
       
           
            dsResult =CF.FetchFTRWorkSheet(projectID,finYear,period,reCreate);
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
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "NETPAYABLE,PAID,PROJECTLIABILITY,ZONALLIABILITY", HeaderText = "Outstanding Amount Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "PROJECTSITE,ACCOUNTANT,ACCOUNTSHEAD,CONTROLCELL", HeaderText = "Payment Recommendations" });

            //Adding stacked header row object to stacked header row collection available in SfDataGrid.
            gridResult.StackedHeaderRows.Add(stackedHeaderRow1);
            this.gridResult.Style.StackedHeaderStyle.BackColor = Color.DarkCyan;
            this.gridResult.Style.StackedHeaderStyle.TextColor = Color.White;

            this.gridResult.ThemeName = "Office2019Colorful";
            this.gridResult.FrozenColumnCount = 11;

           

            

            gridResult.Refresh();
            gridResult.Visible = true;
          }

      

       

        private void PresentFTRCreditors(DataSet ds)
        {
            
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


        private void gridDetails_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.LightCyan;
                else
                    e.Style.BackColor = Color.Khaki;
            }
        }


        private static string GetCellValue(Syncfusion.WinForms.DataGrid.SfDataGrid dGrid, int rowIndex, int columnIndex)
        {
            string cellValue;
            if (columnIndex < 0)
                return string.Empty;
            var mappingName = dGrid.Columns[columnIndex].MappingName;
            var recordIndex = dGrid.TableControl.ResolveToRecordIndex(rowIndex);
            if (recordIndex < 0)
                return string.Empty;
            if (dGrid.View.TopLevelGroup != null)
            {
                var record = dGrid.View.TopLevelGroup.DisplayElements[recordIndex];
                if (!record.IsRecords)
                    return string.Empty;
                var data = (record as RecordEntry).Data;
                cellValue = (data.GetType().GetProperty(mappingName).GetValue(data, null).ToString());
            }
            else
            {
                var record1 = dGrid.View.Records.GetItemAt(recordIndex);
                cellValue = (record1.GetType().GetProperty(mappingName).GetValue(record1, null).ToString());
            }

            return cellValue;
        } 

        private void Open(string fileName)
        {
            System.Diagnostics.Process.Start(fileName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void gridResult_CurrentCellBeginEdit(object sender, CurrentCellBeginEditEventArgs e)
        {
            var cellValue = 
            MessageBox.Show("The editing is completed for the cell (" + e.DataRow.RowIndex + "," + e.DataColumn.ColumnIndex + ")");
            if (e.DataColumn.GridColumn.MappingName == "ProductName")
                e.Cancel = true;
        }

        void options_Exporting(object sender, Syncfusion.WinForms.DataGridConverter.Events.DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
            {
                e.CellStyle.BackGroundColor = Color.LightPink;
                e.CellStyle.ForeGroundColor = Color.White;
                e.CellStyle.FontInfo.Bold = true;
                e.Handled = true;
            }
            else if (e.CellType == ExportCellType.RecordCell)
            {
                e.CellStyle.BackGroundColor = Color.LightSkyBlue;
                e.Handled = true;
            }
            else if (e.CellType == ExportCellType.GroupCaptionCell)
            {
                e.CellStyle.BackGroundColor = Color.Wheat;
                e.Handled = true;
            }
        }
    

       

       
         

       

    }
}
