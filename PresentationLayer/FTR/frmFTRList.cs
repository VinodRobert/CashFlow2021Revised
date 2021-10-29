using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using CashFlow.BusinessLayer;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.GroupingGridExcelConverter;
using Excel = Microsoft.Office.Interop.Excel;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.PivotConverter;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.Data;

namespace CashFlow.PresentationLayer.Cash_Flow 
{
    public partial class frmFTRList : Office2010Form
    {
        ClassFTR FTR = new ClassFTR();
        int loginUserRoleID = CashFlowGlobalVariables.GlobalVariables.RoleID;
        string loginUser = CashFlowGlobalVariables.GlobalVariables.UserID;

        public frmFTRList()
        {
            InitializeComponent();
        }

        private void ResetAll()
        {
            panelNewFTR.Visible = false;
            lblProjectName.Visible = false;
            cmbProjectName.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            cmbProjectName.Text = "Select Project";
            if (loginUserRoleID == 1)
                btnNew.Visible = true;
            else
                btnNew.Visible = false;

        }

        private void LoadProjects()
        {
            DataSet ds = FTR.GetProjectsForFTR(loginUser);
            cmbProjectName.DataSource = ds.Tables[0];
            cmbProjectName.Refresh();
            int noProjects = ds.Tables[0].Rows.Count;
            if (noProjects >= 1)
                btnNew.Enabled = true;
            else
                btnNew.Enabled = false;
        }

        private void frmFTRSubbie_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadProjects();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelNewFTR.Visible = false;
        }
    }
}
