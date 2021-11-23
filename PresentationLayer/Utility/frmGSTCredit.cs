using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.BusinessLayer;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CashFlow 
{
    public partial class frmGSTCredit : Form
    {
        ClassFTR FTR = new ClassFTR();

        public frmGSTCredit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGSTCredit_Load(object sender, EventArgs e)
        {
            DataSet gstCredit = FTR.GSTCredit();
            gridResult.DataSource = gstCredit.Tables[0];

            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "TotalProduct";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total : {Sum:c}";
            summaryColumn1.MappingName = "GSTCREDIT";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);

            this.gridResult.TableSummaryRows.Add(tableSummaryRow1);


            gridResult.Refresh();

        }

        private void gridResult_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.LightSalmon;
                else
                    e.Style.BackColor = Color.Linen;
            }
        }
    }
}
