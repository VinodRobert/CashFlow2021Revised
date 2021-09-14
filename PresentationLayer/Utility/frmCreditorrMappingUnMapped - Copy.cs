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
    public partial class frmCreditorMapping : Form
    {
        CashFlowBL CF = new CashFlowBL();
        List<SelectedRowInformation> SelectedRowsCollection = new List<SelectedRowInformation>();
        DataSet dsPartyCode;
        string cashFlowMarkerForUpdate = string.Empty;
        string ledgerCodeForUpdate = string.Empty;

        public frmCreditorMapping()
        {
            InitializeComponent();
        }

        private void LoadPartyCodes()
        {
            dsPartyCode = CF.FetchMissingCreditorCodes();
            this.chkListLedgerCode.DataSource = dsPartyCode.Tables[0];
            this.chkListLedgerCode.DisplayMember = "PARTYNAME";
            this.chkListLedgerCode.ValueMember = "PARTYCODE";
            this.chkListLedgerCode.AllowSelectAll = true;
            this.chkListLedgerCode.AllowRecursiveChecking = true;
            this.chkListLedgerCode.ShowCheckBoxes = true;
            this.chkListLedgerCode.HotTracking = true;
            chkListLedgerCode.ShowCheckBoxes = true;
            chkListLedgerCode.Refresh();
        }

        private void LoadCashFlowMarkers()
        {
            DataSet dsCashFlowMarkers = CF.FetchCashFlowMappingForPartyCreditor();
            DataTable dtCashFlowMarkers = dsCashFlowMarkers.Tables[0];
            this.cmbCashFlowMarkers.MultiColumn = true;
            this.cmbCashFlowMarkers.ShowColumnHeader = true;
            this.cmbCashFlowMarkers.AlphaBlendSelectionColor = Color.LightBlue;

            this.cmbCashFlowMarkers.DropDownWidth = 600;
            this.cmbCashFlowMarkers.AllowFiltering = true;
          
            DataView view = new DataView(dtCashFlowMarkers);
            this.cmbCashFlowMarkers.DataSource = view;
            this.cmbCashFlowMarkers.DisplayMember = "LEVEL2";
            this.cmbCashFlowMarkers.ValueMember = "STRUCTUREKEY";

            this.cmbCashFlowMarkers.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbCashFlowMarkers.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            
        }
        

        private void frmLedgerMapping_Load(object sender, EventArgs e)
        {
            lblConfirm.Visible = false;
            lblConfirmYesNo.Visible = false;
            txtConfirm.Visible = false;
            LoadPartyCodes();
            LoadCashFlowMarkers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cashFlowMarkerForUpdate = string.Empty;
            string cashFlowMarkerText = string.Empty;
            if (this.SelectedRowsCollection.Count > 0)
            {
                cashFlowMarkerForUpdate = this.SelectedRowsCollection[this.SelectedRowsCollection.Count - 1].StructureKey.ToString();
                cashFlowMarkerText = this.SelectedRowsCollection[this.SelectedRowsCollection.Count - 1].Level2.ToString();
            }
            else
            {
                MessageBox.Show("Select Cash Flow Marker", "Nothing Selected");
            }

            string confirm = "Are You Sure The Selected Party Code(s) Mapped To Cash Flow Marker ---- " + Convert.ToString(cashFlowMarkerText) + " ? ";
            lblConfirm.Text = confirm.ToString();
            lblConfirm.Visible = true;
            lblConfirmYesNo.Visible = true;
            txtConfirm.Text = "No";
            txtConfirm.Visible = true;
        }

        private void cmbCashFlowMarkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Here we are adding selected row information for all rows in MultiColumnComboBox
            if (this.cmbCashFlowMarkers.SelectedItem != null && this.cmbCashFlowMarkers.SelectedItem is DataRowView)
            {
                DataRowView selectedRow = this.cmbCashFlowMarkers.SelectedItem as DataRowView;
                this.SelectedRowsCollection.Add(new SelectedRowInformation(selectedRow.Row["STRUCTUREKEY"].ToString(), selectedRow.Row["FLOWCATEGORY"].ToString(), selectedRow.Row["LEVEL1"].ToString(), selectedRow.Row["LEVEL2"].ToString()));
            }
        }

         


        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            
            string answer = Convert.ToString(txtConfirm.Text);
            DataTable dtPartyCode = dsPartyCode.Tables[0];
            System.Data.DataRow ledgerRow;
             
            int chkItemIndex;
            if (answer=="YES")
            {
                btnClose.Visible = false;
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;
                lblConfirmYesNo.Visible = false;
                chkListLedgerCode.ShowCheckBoxes = true;
                ObservableCollection<int> selectedIndex = new ObservableCollection<int>();

                foreach (var allItems in chkListLedgerCode.View.Items)
                {
                    foreach (var checkedItem in chkListLedgerCode.CheckedItems)
                    {
                        if (allItems == checkedItem)
                        {
                            chkItemIndex = Convert.ToInt16(chkListLedgerCode.View.DisplayItems.IndexOf(allItems));
                            ledgerRow = dtPartyCode.Rows[chkItemIndex];
                            ledgerCodeForUpdate = ledgerRow[0].ToString();
                            CF.UpdatePartyCodeWithCashFlowMarker(ledgerCodeForUpdate, cashFlowMarkerForUpdate,1);
                        }
                    }
                }
                MessageBox.Show("Success !!!!");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
