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
        ClassFTR FTR = new ClassFTR();
        string projectName, ftrNumber;
        DateTime lastUpdate;
        DataSet dsResult;
        int ftrIDToExtract;
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
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "MOBADVANCE,GSTCREDIT,COMPANYLIABILITY,PAYABLEAFTERGST,FINALPAYABLE", HeaderText = "Company Level Details" });
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "PROJECTSITE,ACCOUNTANT,ACCOUNTSHEAD,CONTROLCELL", HeaderText = "Payment Recommendations" });

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
            dsResult = FTR.GetFTRWorkSheet(ftrIDToExtract);
            DisplayGrid();
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

       
       

       
         

       

    }
}
