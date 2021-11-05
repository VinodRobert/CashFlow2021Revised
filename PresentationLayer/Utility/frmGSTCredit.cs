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
            gridResult.Refresh();

        }
    }
}
