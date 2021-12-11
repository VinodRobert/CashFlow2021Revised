using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.BusinessLayer;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;

namespace CashFlow 
{
    public partial class frmCurrentUnMapped : Form
    {
        ClassFTR FTR = new ClassFTR();
        public frmCurrentUnMapped()
        {
            InitializeComponent();
        }

        private void frmSubbieCurrentMapping_Load(object sender, EventArgs e)
        {
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowSorting = true;
            this.gridResult.AllowGrouping = true;
            gridResult.Visible = false;
            btnShow.Visible = true;
            rdCreditor.Checked = false;
            rdSubbie.Checked = false;
            btnExport.Visible = false;
        }

        

        private void SfDataGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Azure;
                else
                    e.Style.BackColor = Color.Bisque;
            }
        }

       

        private void btnShow_Click(object sender, EventArgs e)
        {
            gridResult.Visible = false;
            int vendorTypeID;
            if (rdSubbie.Checked == true)
                vendorTypeID = 2;
            else if (rdCreditor.Checked == true)
                vendorTypeID = 1;
            else
                vendorTypeID = 0;
            if (vendorTypeID == 0)
                return;

            if (vendorTypeID == 1)
                lblHeader.Text = "Creditors -Un-Mapped";
            else
                lblHeader.Text = "Sub Contractors -Un Mapped";

            DataSet dsMasters = FTR.FetchPartiesWithOutMapping(vendorTypeID);
            gridResult.DataSource = null;
            gridResult.DataSource = dsMasters.Tables[0];
            gridResult.QueryRowStyle += SfDataGrid_QueryRowStyle;
            this.gridResult.ThemeName = "Office2016Colorful";
            gridResult.Refresh();
            gridResult.Visible = true;
            btnExport.Visible = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Visible = false;
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            var excelEngine = gridResult.ExportToExcel(gridResult.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created workbook.
                if (MessageBox.Show(this.gridResult, "Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }


        }
    }
}

