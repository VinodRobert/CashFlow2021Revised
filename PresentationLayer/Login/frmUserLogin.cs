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
using CashFlow.PresentationLayer;
using CashFlowGlobalVariables;
namespace CashFlow.PresentationLayer.Login
{
    public partial class frmUserLogin : Form
    {
        CashFlowBL CF = new CashFlowBL();
        private void LoginProcess()
        {
            btnLogin.Enabled = false;
            string userID = Convert.ToString(txtLoginID.Text.Trim());
            string pwd = Convert.ToString(txtPassword.Text.Trim());
            if (rdLan.Checked == true)
                GlobalVariables.connectedBy = 0;
            if (rdRemote.Checked == true)
                GlobalVariables.connectedBy = 1;

            DataSet ds = CF.Login(userID, pwd);

            int existing = Convert.ToInt16(ds.Tables[0].Rows.Count);
            if (existing == 0)
            {
                MessageBox.Show("Invalid User ID or Password ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                btnLogin.Enabled = true;
                return;
            }
            else
            {
                GlobalVariables.UserName = Convert.ToString(ds.Tables[0].Rows[0]["USERNAME"]);
                GlobalVariables.UserID = userID;
                this.Visible = false;
                frmMain _main = new frmMain();
                _main.Show();

            }

        }
        private void ResetAll()
        {
            txtLoginID.Text = "";
            txtPassword.Text = "";
            rdLan.Checked = true;
            rdRemote.Checked = false;
        }
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {
            ResetAll();  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
