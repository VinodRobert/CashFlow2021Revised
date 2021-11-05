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
           
        }

        

       
       

     

       
        
        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

         

         

        

        private void currentMappingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCurrentMapping currentMappingSubbie = new frmCurrentMapping();
            currentMappingSubbie.Show();
        }
 

        

        private void subContractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFTRSubbie ftrSubbie = new frmFTRSubbie();
            ftrSubbie.Show();
        }

        private void creditorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFTRCreditors ftrCreditors = new frmFTRCreditors();
            ftrCreditors.Show();
        }

        private void wORKSHEETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFTRList ftrList = new frmFTRList();
            ftrList.Show();
        }

        

        private void viewCurrentMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrentMapping currentMapping = new frmCurrentMapping();
            currentMapping.Show();
        }

        private void mapReMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMissingMapping mapping = new frmMissingMapping();
            mapping.Show();
        }

        private void uploadGSTCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGSTCredit viewGSTCredit = new frmGSTCredit();
            viewGSTCredit.Show();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUploadGSTCredit uploadGSTCredit = new frmUploadGSTCredit();
            uploadGSTCredit.Show();
        }
    }
}
