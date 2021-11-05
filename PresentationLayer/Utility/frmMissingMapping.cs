using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.BusinessLayer;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CashFlow
{
    public partial class frmMissingMapping : Form
    {
        ClassFTR FTR = new ClassFTR();
        List<SelectedRowInformation> SelectedRowsCollection = new List<SelectedRowInformation>();
        DataSet dsPartyCodes;
        string cashFlowMarkerForUpdate = string.Empty;
        string ledgerCodeForUpdate = string.Empty;
        int vendorTypeID;
        int mappingTypeID;

        public frmMissingMapping()
        {
            InitializeComponent();
        }

       

        private void ResetAll()
        {
           
            lblCategory.Visible = false;
            lblMajorCategory.Visible = false;
            lblMinorCategory.Visible = false;
            btnSave.Visible = false;
            cmbCategory.Visible = false;
            cmbMajorCategory.Visible = false;
            cmbMinorCategory.Visible = false;
            lblPartyCodes.Visible = false;
            chkListParties.Visible = false;
            btnFetch.Visible = true;
            rdUnMapped.Checked = true;
            btnSave.Visible = false;
            cmbVendorType.Enabled = true;
            rdRemap.Enabled = true;
            rdUnMapped.Enabled = true;
            btnFetch.Enabled = true;

        }

        private void LoadVendorTypes()
        {
            List<string> vendorType = new List<string>(2);
         
            vendorType.Add("Creditor");
            vendorType.Add("Sub Contractor");
            cmbVendorType.DataSource = vendorType;
            cmbVendorType.Text = "Select Vendor Type";
            cmbVendorType.Show();
        }

        private void frmLedgerMapping_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadVendorTypes();
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbMinorCategory.Text == "Select")
                return;
            if ((vendorTypeID == 1) && (cmbCategory.Text == "Select"))
                return;

            int mappingID;
            int chkItemIndex;
            int success;
            string partyCodeForUpdate;
            System.Data.DataRow partyRow;
            if (vendorTypeID == 1)
                mappingID = Convert.ToInt16(cmbCategory.SelectedValue);
            else
                mappingID = Convert.ToInt16(cmbMinorCategory.SelectedValue);

            foreach (var allItems in chkListParties.View.Items)
            {
                foreach (var checkedItem in chkListParties.CheckedItems)
                {
                    if (allItems == checkedItem)
                    {
                        chkItemIndex = Convert.ToInt16(chkListParties.View.DisplayItems.IndexOf(allItems));
                        partyRow = dsPartyCodes.Tables[0].Rows[chkItemIndex];
                        partyCodeForUpdate = partyRow[0].ToString();
                        if (mappingTypeID == 1)
                           success = FTR.InsertMapping(vendorTypeID, partyCodeForUpdate, mappingID);
                        else
                           success = FTR.UpdateMapping(vendorTypeID, partyCodeForUpdate, mappingID);
                    }
                }
            }
            MessageBox.Show("Success !!!");
            ResetAll();
        }

      

         


      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void LoadMajorCategory(int vendorTypeID)
        {
            DataSet dsMajorCategory = FTR.getMajorCategory(vendorTypeID);
            cmbMajorCategory.DataSource = dsMajorCategory.Tables[0];
            cmbMajorCategory.Refresh();
            cmbMajorCategory.Visible = true;
            lblMajorCategory.Visible = true;
            cmbMinorCategory.Text = "Select";
            cmbCategory.Text = "Select";
        }


        private void btnFetch_Click(object sender, EventArgs e)
        {
             
            if (cmbVendorType.Text == "Select Vendor Type")
                return;
            cmbVendorType.Enabled = false;
            rdRemap.Enabled = false;
            rdUnMapped.Enabled = false;
            btnFetch.Enabled = false;
            string vendorType = Convert.ToString(cmbVendorType.SelectedValue);
           
            if (vendorType == "Creditor")
                vendorTypeID = 1;
            else
                vendorTypeID = 2;
           
            if (rdRemap.Checked == true)
                mappingTypeID = 2;
            else
                mappingTypeID = 1;
            dsPartyCodes = FTR.getPartiesForMapping(vendorTypeID, mappingTypeID);
            if (dsPartyCodes.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("  No Partites  For Mapping ");
                this.Close();
            }
            this.chkListParties.DataSource = dsPartyCodes.Tables[0];
            this.chkListParties.DisplayMember = "PARTYNAME";
            this.chkListParties.ValueMember = "PARTYCODE";
            this.chkListParties.AllowSelectAll = true;
            this.chkListParties.AllowRecursiveChecking = true;
            this.chkListParties.ShowCheckBoxes = true;
            this.chkListParties.HotTracking = true;
            chkListParties.ShowCheckBoxes = true;
            chkListParties.Refresh();
            chkListParties.Visible = true;
            cmbMajorCategory.Text = "Select";
            lblMinorCategory.Visible = false;
            cmbMinorCategory.Text = "Select";
            cmbMinorCategory.Visible = false;
            cmbCategory.Text = "Select";
            lblCategory.Visible = false;
            cmbCategory.Visible = false;
            btnSave.Visible = false;
            LoadMajorCategory(vendorTypeID);
        }

        private void cmbMajorCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string majorCategory = Convert.ToString(cmbMajorCategory.Text);
            DataSet dsMinorCategory = FTR.getMinorCategory(vendorTypeID,majorCategory);
            cmbMinorCategory.DataSource = dsMinorCategory.Tables[0];
            cmbMinorCategory.Refresh();
            cmbMinorCategory.Visible = true;
            lblMinorCategory.Visible = true;
            cmbCategory.Text = "Select";
            cmbMinorCategory.Text = "Select";
        }

        private void cmbMinorCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vendorTypeID==2)
            {
                lblCategory.Visible = false;
                cmbCategory.Visible = false;
                btnSave.Visible = true;
            }
            else
            {
                string minorCategory = Convert.ToString(cmbMinorCategory.Text);
                DataSet dsCategory = FTR.getCategory(minorCategory);
                cmbCategory.DataSource = dsCategory.Tables[0];
                cmbCategory.Refresh();
                
                lblCategory.Visible = true;
                cmbCategory.Visible = true;
                btnSave.Visible = true;
            }
        }
    }
}
