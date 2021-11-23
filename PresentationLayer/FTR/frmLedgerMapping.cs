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
namespace CashFlow 
{
    public partial class frmLedgerMapping : Form
    {
        ClassFTR FTR = new ClassFTR();
        public frmLedgerMapping()
        {
            InitializeComponent();
        }

        private void frmLedgerMapping_Load(object sender, EventArgs e)
        {
            DataSet ds = FTR.FetchLedgerMapping();
            gridLM.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
