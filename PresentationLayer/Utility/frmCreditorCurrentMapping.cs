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
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace CashFlow 
{
    public partial class frmCreditorCurrentMapping : Form
    {
        CashFlowBL CF = new CashFlowBL();
        public frmCreditorCurrentMapping()
        {
            InitializeComponent();
        }

        private void frmLedgerCodeCurrentMapping_Load(object sender, EventArgs e)
        {
            this.gridLedgerCurrentMapping.AllowFiltering = true;
            this.gridLedgerCurrentMapping.AllowSorting = true;
            this.gridLedgerCurrentMapping.AllowGrouping = true;
            DataSet dsLedgerCurrentMapping = CF.FetchCurrentCreditorCashFlowMapping();
            gridLedgerCurrentMapping.DataSource = dsLedgerCurrentMapping.Tables[0];
            gridLedgerCurrentMapping.QueryRowStyle += SfDataGrid_QueryRowStyle;
            this.gridLedgerCurrentMapping.ThemeName = "Office2016Colorful";
            gridLedgerCurrentMapping.Refresh();
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
    }
}
