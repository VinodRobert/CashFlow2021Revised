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
    public partial class frmCurrentMapping : Form
    {
        ClassFTR FTR = new ClassFTR();
        public frmCurrentMapping()
        {
            InitializeComponent();
        }

        private void frmSubbieCurrentMapping_Load(object sender, EventArgs e)
        {
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowSorting = true;
            this.gridResult.AllowGrouping = true;
            gridResult.Visible = false;
            btnShow.Visible = true;
            rdCreditor.Checked = false;
            rdSubbie.Checked = false;
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

       

        private void btnShow_Click(object sender, EventArgs e)
        {
            gridResult.Visible = false;
            int vendorTypeID;
            if (rdSubbie.Checked == true)
                vendorTypeID = 2;
            else if (rdCreditor.Checked == true)
                vendorTypeID = 1;
            else
                vendorTypeID = 0;
            if (vendorTypeID == 0)
                return;

            if (vendorTypeID == 1)
                lblHeader.Text = "Creditors - Mapping";
            else
                lblHeader.Text = "Sub Contractors - Mapping";

            DataSet dsMasters = FTR.FetchPartiesWithMapping(vendorTypeID);
            gridResult.DataSource = null;
            gridResult.DataSource = dsMasters.Tables[0];
            gridResult.QueryRowStyle += SfDataGrid_QueryRowStyle;
            this.gridResult.ThemeName = "Office2016Colorful";
            gridResult.Refresh();
            gridResult.Visible = true;
        }

    }
}

