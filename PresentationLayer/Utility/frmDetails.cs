using Syncfusion.WinForms.DataGrid.Enums;
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
    public partial class frmDetails : Form
    {
        CashFlowBL CF = new CashFlowBL();
        int currentDetailsID=-1;
        int currentMinorSectionID = -1;
        int currentMajorSectionID = -1;
        string currentDetails=string.Empty;

        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            this.gridSections.ThemeName = "Office2019Colorful";
            this.gridSections.ShowRowHeader = true;
            this.gridSections.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridSections.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridSections.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridSections.Style.RowHeaderStyle.SelectionBackColor = Color.White;

            this.gridSections.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridSections.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridSections.Style.HeaderStyle.Font.Bold = true;

            LoadMajorSections();
            btnDelete.Visible = false;
            cmbMinorSection.Enabled = false;
            txtDetails.Enabled = false;
        }

        private void LoadMajorSections()
        {
            DataSet dsMajor = CF.GetMajorSections();
            cmbMajorSection.DataSource = dsMajor.Tables[0];
            cmbMajorSection.Refresh();
            cmbMajorSection.Text = "Select Major Section";
        }

        private void cmbMajorSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            DataSet dsMinor = new DataSet();
            dsMinor = CF.GetMinorSections(majorSectionID);
            cmbMinorSection.DataSource = dsMinor.Tables[0];
            cmbMinorSection.Refresh();
            cmbMinorSection.Text = "Select Minor Section";
            cmbMinorSection.Enabled = true;
        }

        private void cmbMinorSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            int minorSectionID = Convert.ToInt16(cmbMinorSection.SelectedValue);
            DataSet dsDetails = CF.GetDetails(majorSectionID,minorSectionID);
            gridSections.DataSource = dsDetails.Tables[0];
            gridSections.Refresh();
            int lastPosition = Convert.ToInt16(dsDetails.Tables[1].Rows[0]["LASTPOSITION"]) + 10;
            txtPosition.Value = Convert.ToInt16(lastPosition);
            txtDetails.Enabled = true;
        }


        private void LoadDetails()
        {
            txtDetails.Text = "";
            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            int minorSectionID = Convert.ToInt16(cmbMinorSection.SelectedValue);
            DataSet dsDetails = CF.GetDetails(majorSectionID,minorSectionID);
            gridSections.DataSource = dsDetails.Tables[0];
            gridSections.Refresh();
            int lastPosition = Convert.ToInt16(dsDetails.Tables[1].Rows[0]["LASTPOSITION"]) + 10;
            txtPosition.Value = lastPosition;
        }

       

        private void gridSections_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridSections.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }

        private void gridSections_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text=="Update")
            {
                updateCurrentEntry();
            }


            if (txtDetails.Text.Trim() == "")
                return;
            int duplicate = CF.CheckDuplicateDetails(txtDetails.Text.Trim());
            if (duplicate==1)
            {
                MessageBox.Show("Duplicate Details", "Duplicate",  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            int minorSectionID = Convert.ToInt16(cmbMinorSection.SelectedValue);

            int j = CF.AddDetails(majorSectionID,minorSectionID,txtDetails.Text.Trim(), Convert.ToInt16(txtPosition.Value));

            txtDetails.Text = "";
            LoadDetails();
            MessageBox.Show("Success !!", "Success", MessageBoxButtons.OK);
                
        }

        private void gridSections_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            var rowIndex = e.DataRow.RowIndex;

            var columnIndex = e.DataColumn.ColumnIndex;
            // var cellValue = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, e.DataColumn.GridColumn.MappingName);
            var cellDetailsValueID = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "DETAILSID");
            var cellMinorSectionValueID = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "MINORSECTIONID");
            var cellMajorSectionValueID = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "MAJORSECTIONID");


            var cellDetails = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "Details");


            int detailsID = Convert.ToInt16(cellDetailsValueID);
            int majorSectionID = Convert.ToInt16(cellMajorSectionValueID);
            int minorSectionID = Convert.ToInt16(cellMinorSectionValueID);

            string details = Convert.ToString(cellDetails);
             


            currentDetailsID = detailsID;
            currentDetails = Convert.ToString(details);

            currentMajorSectionID = Convert.ToInt16(majorSectionID);
            currentMinorSectionID = Convert.ToInt16(minorSectionID);
 

            DataSet dsCurrentDetails = CF.GetDetailsHavingDetailsID(currentDetailsID);
            btnAdd.Text = "Update";
            

            txtDetails.Text = Convert.ToString(currentDetails);
            txtPosition.Value = Convert.ToInt16(dsCurrentDetails.Tables[0].Rows[0]["POSITION"]);
            btnDelete.Visible = true;


        }

        private void updateCurrentEntry()
        {
            if (txtDetails.Text.Trim() == "")
                return;
            if ( (currentMajorSectionID!=Convert.ToInt16(cmbMajorSection.SelectedValue ))  || (currentMinorSectionID!=Convert.ToInt16(cmbMinorSection.SelectedValue)) )
            {
                int duplicate = CF.CheckDuplicateDetails(txtDetails.Text.Trim());
                if (duplicate == 1)
                {
                    MessageBox.Show("Duplicate Details Section", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            int minorSectionID = Convert.ToInt16(cmbMinorSection.SelectedValue);

            int j = CF.UpdateDetails(majorSectionID,minorSectionID,currentDetailsID,txtDetails.Text.Trim(), Convert.ToInt16(txtPosition.Value));
            txtDetails.Text = "";
            LoadDetails();
            btnAdd.Text = "Add";
            MessageBox.Show("Success !!", "Success", MessageBoxButtons.OK);

        }


       

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this entry ?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int j = CF.DeleteDetails(currentDetailsID);
                btnAdd.Text = "Add";
                btnDelete.Visible = false;
                LoadDetails();
            }
            else
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
