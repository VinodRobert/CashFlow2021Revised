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
    public partial class frmCloseFTR : Form
    {
        ClassFTR FTR = new ClassFTR();
        public frmCloseFTR()
        {
            InitializeComponent();
        }

        private void frmCloseFTR_Load(object sender, EventArgs e)
        {
            txtFTRNumber.Text = "FTR Number";
            lblConfirm.Visible = false;
            txtConfirm.Visible = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //txtFTRNumber.Enabled = false;
            //btnSubmit.Enabled = false;

            //if (txtFTRNumber.Text == "FTR Number")
            //    return;
            //string ftrNumber = Convert.ToString(txtFTRNumber.Text.Trim());

            ////DataSet dsFTR = FTR.CheckFTRForClose(ftrNumber);

            //if (dsFTR.Tables[0].Rows.Count==0)
            //{
            //    MessageBox.Show(" Un Known FTR Number ");
            //    return;
            //}

            //string currentUser = CashFlowGlobalVariables.GlobalVariables.UserID;

            //string owner = Convert.ToString(dsFTR.Tables[0].Rows[0]["OWNERT"]);
            //if (currentUser!=owner)
            //{
            //    MessageBox.Show("You Are Not The OWner Of This FTR");
            //    return;
            //}

            //lblConfirm.Visible = true;
            //txtConfirm.Visible = true;

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            //if (txtConfirm.Text.ToUpper().Trim()=="CONFIRM")
            //{
            //    int j = FTR.CloseFTR(txtFTRNumber.Text.Trim());
            //    MessageBox.Show("Success !!!");
            //    this.Close();
            //}
        }
    }
}
