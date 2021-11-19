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
    public partial class frmUserInput : Form
    {
        ClassFTR FTR = new ClassFTR();
        DataSet dsUserInput;
        int noProject = 1;
        public frmUserInput()
        {
            InitializeComponent();
        }

        private void ResetAll()
        {
            lblProjectName.Visible = false;
            btnFetch.Visible = false;
            btnUpdate.Visible = false;
            btnClose.Visible = true;
            lblMonthName.Visible = false;
            lblReceivable.Visible = false;
            lblMisc.Visible = false;
            lblHireCharges.Visible = false;
            gridHire.Visible = false;
            gridMisc.Visible = false;
            gridReceivable.Visible = false;
        }

        private void PopulateProjects()
        {
            string loginUser = CashFlowGlobalVariables.GlobalVariables.UserID;
            DataSet dsProject = FTR.FetchProjectsForUserInputs(loginUser);
            if (dsProject.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Open FTR");
                noProject = 0;
                return;
            }
            else
            {
                lblProjectName.Visible = true;
                cmbProject.DataSource = dsProject.Tables[0];
                cmbProject.Text = "Select Project";
                cmbProject.Refresh();
                btnFetch.Visible = true;
            }
        }
        private void frmCloseFTR_Load(object sender, EventArgs e)
        {
            ResetAll();
            PopulateProjects();
            if (noProject == 0)
                this.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (cmbProject.Text == "Select Project")
                return;
            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
            dsUserInput = FTR.FetchUserInputs(projectID);
            gridReceivable.DataSource = dsUserInput.Tables[0];
            gridHire.DataSource = dsUserInput.Tables[1];
            gridMisc.DataSource = dsUserInput.Tables[2];
            string lblUserInputPeriod = "For Period " + Convert.ToString(dsUserInput.Tables[3].Rows[0]["CALENDARMONTH"]) + " - " + Convert.ToString(dsUserInput.Tables[3].Rows[0]["CALENDARYEAR"]);
            lblMonthName.Text = lblUserInputPeriod;
            lblMonthName.Visible = true;
            gridReceivable.Refresh();
            gridMisc.Refresh();
            gridHire.Refresh();
            lblHireCharges.Visible = true;
            lblReceivable.Visible = true;
            lblMisc.Visible = true;
            btnUpdate.Visible = true;
            btnFetch.Enabled = false;
            gridHire.Visible = true;
            gridReceivable.Visible = true;
            gridMisc.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowID;
            int result;
            decimal amount;
            for (int i = 0; i <=2; i++)
            {
                for (int j = 0; j <= dsUserInput.Tables[i].Rows.Count - 1; j++)
                { 
                    rowID = Convert.ToInt16(dsUserInput.Tables[i].Rows[j]["INPUTID"]);
                    amount = Convert.ToDecimal(dsUserInput.Tables[i].Rows[j]["AMOUNT"]);
                    result = FTR.UpdateUserInputs(rowID, amount);
                }

            }
            MessageBox.Show("Success !!!");
            this.Close();
        }
    }
}
