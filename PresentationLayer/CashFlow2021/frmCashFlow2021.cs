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



namespace CashFlow.PresentationLayer.Cash_Flow 
{
    public partial class frmCashFlow2021 : Office2010Form
    {
        CashFlowBL CF = new CashFlowBL();
        string headerA;
        string headerB;
        string projectName;
        string cashFlowPeriod;
        string excelFileName;
        string tempExcelFileName;
        string exportFileName;
        string pdfFileName;
        int firstTime;
        int unMappedEntries;

        public frmCashFlow2021()
        {
            InitializeComponent();
           
        }
       
        private void ResetAll()
        {
            firstTime = 0;
            unMappedEntries = 1;
            cmbPeriod.Text = "Select Month";
            cmbProject.Text = "Select Project";
            btnExcel.Visible = false;
            btnReset.Visible = false;
            this.gridTransactions.AllowSorting = true;
            this.gridTransactions.ShowSortNumbers = true;
            this.gridTransactions.AllowFiltering = true;
            this.gridTransactions.ShowRowHeader = true;
            this.gridTransactions.Style.RowHeaderStyle.BackColor = Color.CadetBlue;

            this.gridTransactions.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridTransactions.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridTransactions.Style.RowHeaderStyle.SelectionBackColor = Color.White;

            this.gridTransactions.Columns["PARTYCODE"].AllowGrouping = true;
            this.gridTransactions.Columns["BANK"].AllowGrouping = true;
            tabControlResult.Visible = false;
            gridDetailsPrint.Visible = false;

        }

        private void LoadProjects()
        {
            DataSet ds = CF.GetProjects();
            cmbProject.DataSource = ds.Tables[0];
            cmbProject.Refresh();
        }

        private void LoadPeriods()
        {
            DataSet ds = CF.GetPeriods();
            cmbPeriod.DataSource = ds.Tables[0];
            cmbPeriod.Refresh();
        }

        private void frmCashFlow2021_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadProjects();
            LoadPeriods();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void PresentCashFlow(DataSet dsResult)
        {
            DataTable dsHeader = dsResult.Tables[4];
            headerA = Convert.ToString(dsHeader.Rows[0]["HEADERA"]);
            headerB = Convert.ToString(dsHeader.Rows[0]["HEADERB"]);


            gridTransactions.DataSource = dsResult.Tables[0];
            gridTransactions.Refresh();
            gridUnMapped.DataSource = dsResult.Tables[3];
            gridUnMapped.Refresh();
            gridUnMapped.Visible = true;
            gridDetails.DataSource = dsResult.Tables[1];
            gridDetailsPrint.DataSource = dsResult.Tables[1];
            gridDetails.Refresh();

            int numberOfUnMappedEntries = dsResult.Tables[3].Rows.Count;
            if (numberOfUnMappedEntries == 0)
                unMappedEntries = 0;
            else
                unMappedEntries = 1;

            if (unMappedEntries == 0)
                tabControlResult.TabPages[3].Enabled = false;
            else
                tabControlResult.TabPages[3].Enabled = true;



            if (firstTime == 0)
            {
                this.gridDetails.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "LEVEL1" });
                this.gridDetails.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "LEVEL2" });
                this.gridDetails.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "LEVEL3" });
                firstTime = 1;
            }
            this.gridDetails.ExpandGroupsAtLevel(3);
            this.gridDetails.GroupCaptionTextFormat = "{Key} : {ItemsCount}";
            this.gridDetails.AutoFitGroupDropAreaItem = true;
            this.gridDetails.GroupPanel.Margin = new Padding(12);
            this.gridDetails.Style.GroupDropAreaStyle.BackColor = Color.LightSkyBlue;
            this.gridDetails.Style.GroupDropAreaStyle.TextColor = Color.Red;
            this.pivotGridCashFlow.ItemSource = dsResult.Tables[2];



         
            this.pivotGridCashFlow.PivotRows.Add(new PivotItem { FieldMappingName = "LEVEL1", TotalHeader = "Total" });
            this.pivotGridCashFlow.PivotRows.Add(new PivotItem { FieldMappingName = "LEVEL2", TotalHeader = "Total" });
            this.pivotGridCashFlow.PivotRows.Add(new PivotItem { FieldMappingName = "LEVEL3", TotalHeader = "Total" });
            this.pivotGridCashFlow.PivotCalculations.Add(new PivotComputationInfo { FieldHeader = headerA, FieldName = "AMOUNTTILLPERIOD", Format = "#,##0.00", SummaryType = SummaryType.DecimalTotalSum });
            this.pivotGridCashFlow.PivotCalculations.Add(new PivotComputationInfo { FieldHeader = headerB, FieldName = "AMOUNTTHISPERIOD", Format = "#,##0.00", SummaryType = SummaryType.DecimalTotalSum });
           

            this.pivotGridCashFlow.AllowFiltering = true;
            this.pivotGridCashFlow.ShowGroupBar = true;
            this.pivotGridCashFlow.AllowSorting = true;
            this.pivotGridCashFlow.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridCashFlow.TableControl.ExpandAllGroups();
            this.pivotGridCashFlow.TableControl.ExpandAllRowGroups();
            this.pivotGridCashFlow.TableControl.ExpandAllColumnGroups();
           
            pivotGridCashFlow.TableModel.Model.ColWidths[1] = 100;
            pivotGridCashFlow.TableModel.Model.ColWidths[2] = 250;
            pivotGridCashFlow.TableModel.Model.ColWidths[3] = 350;
            pivotGridCashFlow.TableModel.Model.ColWidths[4] = 150;
            pivotGridCashFlow.TableModel.Model.ColWidths[5] = 150;
            pivotGridCashFlow.TableControl.GroupDropArea.ColWidthsChanged += GroupDropArea_ColWidthsChanged;

            this.pivotGridCashFlow.GridVisualStyles = GridVisualStyles.Office2010Blue;

           

            this.pivotGridCashFlow.ShowGrandTotals = true;
            this.pivotGridCashFlow.ShowGroupBar = true;
            
            pivotGridCashFlow.Refresh();
            tabControlResult.Visible = true;
            btnExcel.Enabled = true;
            btnReset.Enabled = true;
            btnReset.Visible = true;
        }

       

        private void GroupDropArea_ColWidthsChanged(object sender, GridRowColSizeChangedEventArgs e)
        {
            pivotGridCashFlow.TableModel.Model.ColWidths[1] = 100;
            pivotGridCashFlow.TableModel.Model.ColWidths[2] = 250;
            pivotGridCashFlow.TableModel.Model.ColWidths[3] = 350;
            pivotGridCashFlow.TableModel.Model.ColWidths[4] = 150;
            pivotGridCashFlow.TableModel.Model.ColWidths[5] = 150;
        }


        private void btnnView_Click(object sender, EventArgs e)
        {
            int finyear;
            finyear = Convert.ToInt16(txtFinYear.Text);
            if (cmbPeriod.Text == "Select Month")
                return;
            if (cmbPeriod.Text == "Select Project")
                return;
            cmbPeriod.Enabled = false;
            cmbProject.Enabled = false;
            txtFinYear.Enabled = false;
            projectName = Convert.ToString(cmbProject.Text);
            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
            int finYear = Convert.ToInt16(txtFinYear.Text);
            int period = Convert.ToInt16(cmbPeriod.SelectedValue);
          
            DataSet dsResult = CF.FetchCF(projectID,finYear,period);

            if ((period >= 1) && (period <= 9))
            {
                finYear = finYear - 1;
                cashFlowPeriod = "From Inception to " + finYear.ToString() + " - " + Convert.ToString(cmbPeriod.Text);
            }
            else
            {
                cashFlowPeriod = "From Inception to " + finYear.ToString() + " - " + Convert.ToString(cmbPeriod.Text);
            }

            string directoryName = @"C:\MIS\ExcelFiles\";
            excelFileName = Convert.ToString(projectID);
            pdfFileName = Convert.ToString(projectID);
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            excelFileName = excelFileName + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xlsx";
            tempExcelFileName = "Temp" + excelFileName;
            exportFileName = "export" + excelFileName;
            excelFileName = directoryName + excelFileName;
            exportFileName = directoryName + exportFileName;
            tempExcelFileName = directoryName + tempExcelFileName;
            pdfFileName = directoryName + pdfFileName;



            int dataExists = Convert.ToInt16(dsResult.Tables[0].Rows.Count);
            if (dataExists == 0)
            {
                MessageBox.Show("No Data Available !!");
                this.Close();
            }
            else
            {
                PresentCashFlow(dsResult);
            }
        }

        private void gridTransactions_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }


        private void gridUnMapped_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == Syncfusion.WinForms.DataGrid.Enums.RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.LightCyan;
                else
                    e.Style.BackColor = Color.Khaki;
            }
        }




        private void Open(string fileName)
        {
            System.Diagnostics.Process.Start(fileName);
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            var options = new Syncfusion.WinForms.DataGridConverter.ExcelExportingOptions();
            ExcelEngine excelEngine = new ExcelEngine();
            IWorkbook workBook = excelEngine.Excel.Workbooks.Create();
            IApplication application = excelEngine.Excel;

           
            options.AllowOutlining = true;
            options.StartRowIndex = 3;
            options.StartColumnIndex = 1;
            options.Exporting += options_Exporting;

            gridDetails.ExportToExcel(gridDetails.View, options, workBook.Worksheets[0]);
            gridTransactions.ExportToExcel(gridTransactions.View, options, workBook.Worksheets[1]);

            if (unMappedEntries!=0)
                gridUnMapped.ExportToExcel(gridUnMapped.View, options, workBook.Worksheets[2]);

            workBook.Worksheets[0].Name = "Cash Flow Details";
            workBook.Worksheets[1].Name = "Trasaction Dump";
            if (unMappedEntries!=0)
                workBook.Worksheets[2].Name = "Un-Mapped Transactons";

            // Work Sheet [0]  Cash Flow Details 
            workBook.Worksheets[0].Range["A1:J1"].Merge();
            IRange rangeProjectName = workBook.Worksheets[0].Range["A1"];
            rangeProjectName.Text = projectName;
            rangeProjectName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            IRichTextString richTextProjectName = rangeProjectName.RichText;

            IFont redFont = workBook.CreateFont();
            redFont.Bold = true;
            redFont.Italic = false;
            redFont.RGBColor = Color.Red;
            int headerLength = projectName.Length;
            redFont.Size = 20;
            richTextProjectName.SetFont(0, headerLength, redFont);


            workBook.Worksheets[0].Range["A2:J2"].Merge();
            IRange rangeDetails = workBook.Worksheets[0].Range["A2"];
            string detailsText = "Cash Flow (Details) " + cashFlowPeriod.Trim();
            rangeDetails.Text = detailsText;
            rangeDetails.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            IRichTextString richTextDetails = rangeDetails.RichText;


            IFont blueFont = workBook.CreateFont();
            blueFont.Bold = true;
            blueFont.Italic = false;
            blueFont.RGBColor = Color.Blue;
            int headerLength2 = detailsText.Length;
            blueFont.Size = 15;
            richTextDetails.SetFont(0, headerLength2, blueFont);



            //   Work Sheet - 1    Transaction Dump // 

            workBook.Worksheets[1].Range["A1:J1"].Merge();
            rangeProjectName = workBook.Worksheets[1].Range["A1"];
            rangeProjectName.Text = projectName;
            rangeProjectName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            richTextProjectName = rangeProjectName.RichText;
            richTextProjectName.SetFont(0, headerLength, redFont);


            workBook.Worksheets[1].Range["A2:J2"].Merge();
            rangeDetails = workBook.Worksheets[1].Range["A2"];
            string transactionText = "Cash Flow (Transaction Dump) " + cashFlowPeriod.Trim();
            rangeDetails.Text = transactionText;
            rangeDetails.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            richTextDetails = rangeDetails.RichText;
            headerLength2 = transactionText.Length;
            richTextDetails.SetFont(0, headerLength2, blueFont);



            if (unMappedEntries != 0)
            {
                workBook.Worksheets[2].Range["A1:J1"].Merge();
                rangeProjectName = workBook.Worksheets[2].Range["A1"];
                rangeProjectName.Text = projectName;
                rangeProjectName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                richTextProjectName = rangeProjectName.RichText;
                richTextProjectName.SetFont(0, headerLength, redFont);
              

                workBook.Worksheets[2].Range["A2:J2"].Merge();

                rangeDetails = workBook.Worksheets[2].Range["A2"];
                string unmappedText = "Cash Flow (UnMapped Transactions Dump) " + cashFlowPeriod.Trim();
                rangeDetails.Text = unmappedText;
                rangeDetails.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                richTextDetails = rangeDetails.RichText;
                headerLength2 = unmappedText.Length;
                richTextDetails.SetFont(0, headerLength2, blueFont);

            }



            workBook.Version = ExcelVersion.Excel2013;

           
            workBook.SaveAs(exportFileName);

            Open(exportFileName);

         

              
          
         
            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tabControlResult.Visible = false;
            cmbPeriod.Enabled = true;
            cmbProject.Enabled = true;
            txtFinYear.Enabled = true;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.pivotGridCashFlow.TableControl.ExpandAllGroups();
            this.pivotGridCashFlow.TableControl.ExpandAllRowGroups();
            this.pivotGridCashFlow.TableControl.ExpandAllColumnGroups();

        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.pivotGridCashFlow.TableControl.CollapseAllGroups();
            this.pivotGridCashFlow.TableControl.CollapseAllRowGroups();
            this.pivotGridCashFlow.TableControl.CollapseAllColumnGroups();

        }

        private void chkSubTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubTotal.Checked==true)
            {
                this.pivotGridCashFlow.ShowSubTotals = true;
            }
            else
            {
                this.pivotGridCashFlow.ShowSubTotals = false;
            }
            this.pivotGridCashFlow.Refresh();
        }

        private void chkLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLayout.Checked==true)
            {
                this.pivotGridCashFlow.RowPivotsOnly = true;
                this.pivotGridCashFlow.Refresh();
                this.pivotGridCashFlow.TableControl.AllowRowPivotFiltering = true;
                this.pivotGridCashFlow.AllowSorting = true;

            }
            chkLayout.Enabled = false;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            

            ExcelExport excelExport = new ExcelExport(this.pivotGridCashFlow, Syncfusion.XlsIO.ExcelVersion.Excel2010,ExportModes.Cell);
            excelExport.Export(tempExcelFileName);

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;

                //Open an existing Excel 2013 file
                IWorkbook workbook = excelEngine.Excel.Workbooks.Open(tempExcelFileName, ExcelOpenType.Automatic);

                //Save it as "Excel 97 to 2003" format
                workbook.Version = ExcelVersion.Excel2016;
                IWorksheet worksheet = workbook.Worksheets[0];
                worksheet.Name = "Cash Flow";


                Syncfusion.XlsIO.IRange range;
                int rowCount = worksheet.UsedRange.LastRow;
                int colCount = worksheet.UsedRange.LastColumn;
                string rangeName;
                for (int i = 1; i <= rowCount; i++)
                {
                    rangeName = "A" + Convert.ToString(i).Trim() + ":E" + Convert.ToString(i).Trim();
                    range = worksheet.Range[rangeName];
                    range.BorderAround(ExcelLineStyle.Dotted);
                }

                worksheet.Range["A1"].ColumnWidth = 20;
                worksheet.Range["B1"].ColumnWidth = 20;
                worksheet.Range["C1"].ColumnWidth = 40;
                worksheet.Range["D1"].ColumnWidth = 30;
                worksheet.Range["E1"].ColumnWidth = 30;
                worksheet.Range["D2"].NumberFormat = "#,##0";
                worksheet.Range["E2"].NumberFormat = "#,##0";


                worksheet.InsertColumn(1);
                worksheet.InsertRow(1);
                worksheet.InsertRow(1);
                worksheet.InsertRow(1);

                worksheet.Range["B1:F1"].Merge();
                IRange rangeCompanyName = worksheet.Range["B1:F1"];
                rangeCompanyName.Text = "Capacite InfraProjects Limited";
                rangeCompanyName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                IRichTextString richTextCompanyName = rangeCompanyName.RichText;

                IFont cyanFont = workbook.CreateFont();
                cyanFont.Bold = true;
                cyanFont.Italic = false;
                cyanFont.RGBColor = Color.DarkViolet;
                cyanFont.Size = 16;
                richTextCompanyName.SetFont(0, 30, cyanFont);



                worksheet.Range["B2:F2"].Merge();
                IRange rangeProjectName = worksheet.Range["B2:F2"];
                rangeProjectName.Text = projectName;
                rangeProjectName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                IRichTextString richTextProjectName = rangeProjectName.RichText;

                IFont redFont = workbook.CreateFont();
                redFont.Bold = true;
                redFont.Italic = false;
                redFont.RGBColor = Color.Red;
                int headerLength = projectName.Length;
                redFont.Size = 14;
                richTextProjectName.SetFont(0, headerLength, redFont);



                worksheet.Range["B3:F3"].Merge();
                IRange rangeCashFlowPeriod = worksheet.Range["B3:F3"];
                string detailsText = "Cash Flow " + cashFlowPeriod.Trim();
                rangeCashFlowPeriod.Text = detailsText;
                rangeCashFlowPeriod.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                IRichTextString richTextDetails = rangeCashFlowPeriod.RichText;

                IFont blueFont = workbook.CreateFont();
                blueFont.Bold = true;
                blueFont.Italic = false;
                blueFont.RGBColor = Color.Blue;
                int detailsLength = detailsText.Length;
                redFont.Size = 12;
                richTextDetails.SetFont(0, detailsLength, blueFont);


                workbook.SaveAs(excelFileName);
            }

            Open(excelFileName);


        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PivotPdfExport pdfExport = new PivotPdfExport(this.pivotGridCashFlow);
            pdfExport.Export(pdfFileName);
            Open(pdfFileName);
        }

        private void tabControlResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTabIndex = tabControlResult.SelectedIndex;
            if (currentTabIndex==0)
            {
                btnExcel.Visible = false;
            }
            else
            {
                btnExcel.Visible = true;
            }
        }

        private void pivotGridCashFlow_Click(object sender, EventArgs e)
        {

        }
    }
}
