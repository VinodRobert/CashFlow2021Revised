using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.PresentationLayer.Cash_Flow;
using CashFlow.PresentationLayer.Login;
using Syncfusion.Windows.Forms;

namespace CashFlow.PresentationLayer.Login
{
    public partial class frmMain : Office2010Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void viewCashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCashFlow2021 cashFlow2021 = new frmCashFlow2021();
            cashFlow2021.Show();

        }

        
       

        private void frmMain_Load(object sender, EventArgs e)
        {
            stripLoginName.Text   = "Login ID :  " + CashFlowGlobalVariables.GlobalVariables.UserName;
            stripProjectName.Text = "                                               Project Name : " + CashFlowGlobalVariables.GlobalVariables.projectName;
        }

        

       
       

     

       
        
        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void missingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerMapping ledgerMapping = new frmLedgerMapping();
            ledgerMapping.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerCodeCurrentMapping ledgerCodeCurrentMapping = new frmLedgerCodeCurrentMapping();
            ledgerCodeCurrentMapping.Show();
        }

        private void remappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerReMapping ledgerReMapping = new frmLedgerReMapping();
            ledgerReMapping.Show();
        }

        private void curentMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditorCurrentMapping currentMappingCreditor = new frmCreditorCurrentMapping();
            currentMappingCreditor.Show();
        }

        private void currentMappingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSubbieCurrentMapping currentMappingSubbie = new frmSubbieCurrentMapping();
            currentMappingSubbie.Show();
        }

        private void missingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreditorMapping creditorMapping = new frmCreditorMapping();
            creditorMapping.Show();
        }

        private void missedMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubbieMappingUnMapped subbieMapping = new frmSubbieMappingUnMapped();
            subbieMapping.Show();
        }

        private void reMappingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreditorReMapping creditorReMap = new frmCreditorReMapping();
            creditorReMap.Show();
        }
    }
}
