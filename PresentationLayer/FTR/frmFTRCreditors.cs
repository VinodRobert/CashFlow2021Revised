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
    public partial class frmFTRCreditors : Office2010Form
    {
        CashFlowBL CF = new CashFlowBL();
        DataSet dsResult;
        string projectName;
       
        string excelFileName;
        string tempExcelFileName;
        string exportFileName;
       
        int firstTime;
      

        public frmFTRCreditors()
        {
            InitializeComponent();
        }
       
        private void ResetAll()
        {
            firstTime = 0;
            cmbProject.Text = "Select Project";
            btnExcel.Visible = false;
            btnReset.Visible = false;
            tabControlResult.Visible = false;
        }

        private void LoadProjects()
        {
            DataSet ds = CF.GetProjects();
            cmbProject.DataSource = ds.Tables[0];
            cmbProject.Refresh();
        }

   
        private void frmFTRSubbie_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadProjects();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnView_Click(object sender, EventArgs e)
        {
            btnnView.Enabled = false;
            
            int finyear;
            finyear = Convert.ToInt16(txtFinYear.Text);

            cmbProject.Enabled = false;
            txtFinYear.Enabled = false;
            projectName = Convert.ToString(cmbProject.Text);
            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
            int finYear = Convert.ToInt16(txtFinYear.Text);
           
            dsResult = CF.FetchFTRCreditors(projectID,finYear);

            string directoryName = @"C:\MIS\ExcelFiles\";
            excelFileName = Convert.ToString(projectID);
     
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            excelFileName = excelFileName + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xlsx";
            tempExcelFileName = "Temp" + excelFileName;
            exportFileName = "export" + excelFileName;
            excelFileName = directoryName + excelFileName;
            exportFileName = directoryName + exportFileName;
            tempExcelFileName = directoryName + tempExcelFileName;
          

            int dataExists = Convert.ToInt16(dsResult.Tables[0].Rows.Count);
            if (dataExists == 0)
            {
                MessageBox.Show("No Data Available !!");
                this.Close();
            }
            else
            {
                PresentFTRSubbie(dsResult);
            }
        }

        private void PresentFTRSubbie(DataSet ds)
        {
            gridResult.DataSource = ds.Tables[1];
            gridResult.Refresh();
            gridDetails.DataSource = ds.Tables[0];
            gridDetails.Refresh();
            gridDetails.Visible = true;
            gridResult.Visible = true;
            tabControlResult.Visible = true;
            tabDetails.Visible = true;
            btnExcel.Visible = true;
            btnReset.Enabled = true;
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

            int numberRowsinResult = Convert.ToInt32(dsResult.Tables[1].Rows.Count);
            numberRowsinResult = numberRowsinResult +3 ;
            gridResult.ExportToExcel(gridResult.View, options, workBook.Worksheets[0]);
            gridDetails.ExportToExcel(gridDetails.View, options, workBook.Worksheets[1]);


            workBook.Worksheets[0].Name = "FTR-Creditors (Live) ";
            workBook.Worksheets[1].Name = "Transaction Dump";
            

            // Work Sheet [0]  Cash Flow Details 
            workBook.Worksheets[0].Range["A1:M1"].Merge();
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


            workBook.Worksheets[0].Range["A2:M2"].Merge();
            IRange rangeDetails = workBook.Worksheets[0].Range["A2"];
            string detailsText = "Fund Transfer Request - Creditors (Live)  " ;
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

            string tableRange = "A3:M" + Convert.ToString(numberRowsinResult);
            IListObject table = workBook.Worksheets[0].ListObjects.Create("Table1", workBook.Worksheets[0][tableRange]);
            //Creating a table
          
            //Formatting table with a built-in style
            table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium8;

            //   Work Sheet - 1    Transaction Dump // 

            workBook.Worksheets[1].Range["A1:P1"].Merge();
            rangeProjectName = workBook.Worksheets[1].Range["A1"];
            rangeProjectName.Text = projectName;
            rangeProjectName.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            richTextProjectName = rangeProjectName.RichText;
            richTextProjectName.SetFont(0, headerLength, redFont);


            workBook.Worksheets[1].Range["A2:P2"].Merge();
            rangeDetails = workBook.Worksheets[1].Range["A2"];
            string transactionText = "Transaction Dump  ";
            rangeDetails.Text = transactionText;
            rangeDetails.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            richTextDetails = rangeDetails.RichText;
            headerLength2 = transactionText.Length;
            richTextDetails.SetFont(0, headerLength2, blueFont);

            numberRowsinResult = Convert.ToInt32(dsResult.Tables[0].Rows.Count);
            numberRowsinResult = numberRowsinResult + 3;
            tableRange = "A3:P" + Convert.ToString(numberRowsinResult);
            table = workBook.Worksheets[1].ListObjects.Create("Table2", workBook.Worksheets[1][tableRange]);
            table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium23;





            workBook.Version = ExcelVersion.Excel2016;

           
            workBook.SaveAs(exportFileName);

            Open(exportFileName);

         

              
          
         
            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tabControlResult.Visible = false;
            cmbProject.Enabled = true;
            txtFinYear.Enabled = true;
            btnnView.Enabled = true;
            btnReset.Enabled = false;
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

       

    }
}
