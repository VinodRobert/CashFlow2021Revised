using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml;
using SQLHelper;
using Syncfusion.XlsIO;
using Syncfusion.WinForms.Input.Enums;
using CashFlow.BusinessLayer;

namespace CashFlow 
{
    public partial class frmUploadGSTCredit : Form
    {
        string gstExcelFileName;
        ClassFTR FTR = new ClassFTR();

        DataTable GSTDataTable;
        
        public frmUploadGSTCredit()
        {
            InitializeComponent();
        }

        private void ResetAll()
        {
            btnUpload.Visible = false;
            btnRead.Visible = false;
            gridResult.Visible = false;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Excel Files Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = openFileDialog1.FileName;
                lblFileName.Visible = true;
                gstExcelFileName = openFileDialog1.FileName;
            }
            if (lblFileName.Text != "")
            {
                btnRead.Enabled = true;
                btnRead.Visible = true;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            btnBrowse.Enabled = false;
            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;
            IWorkbook workbook;
            IWorksheet worksheet;
            try
            {
                workbook = application.Workbooks.Open(gstExcelFileName);
            }
            catch
            {

               
                MessageBox.Show(this, "File Already Opened. Close it and Try again !", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                return;
            }


            worksheet = workbook.Worksheets[0];



            //Read data from spreadsheet.
            GSTDataTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
            this.gridResult.DataSource = GSTDataTable;


            this.gridResult.Style.CellStyle.BackColor = Color.AliceBlue;
            this.gridResult.Style.CellStyle.TextColor = Color.DarkBlue;

            this.gridResult.Columns["AMOUNT"].CellStyle.BackColor = Color.PaleTurquoise;
            this.gridResult.Columns["AMOUNT"].CellStyle.TextColor = Color.DarkRed;

            this.gridResult.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridResult.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridResult.Style.HeaderStyle.Font.Bold = true;

            this.gridResult.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            workbook.Close();

            //No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = false;
            excelEngine.Dispose();


            btnRead.Enabled = false;

            btnUpload.Enabled = true;
            btnUpload.Visible = true;

        }

        private void gridResult_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridResult.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnUpload.Enabled = false;
            int rowCount = GSTDataTable.Rows.Count;
            string partyCode;
            decimal amount;
            int existing;
            int success;

            for (int i = 0; i <= rowCount - 1; i++)
            {
                partyCode = Convert.ToString(GSTDataTable.Rows[i][0]);
                amount = Convert.ToDecimal(GSTDataTable.Rows[i][1]);
                existing = FTR.CheckAlreadyHaveGSTEntry(partyCode);
                if (existing == 0)
                {
                   success = FTR.AddGSTEntry(partyCode, amount, 0);
                }
                else
                {
                   success = FTR.AddGSTEntry(partyCode, amount, 1);
                }
            }
         
            MessageBox.Show(this, "Success !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            return;
        }
    }
}
