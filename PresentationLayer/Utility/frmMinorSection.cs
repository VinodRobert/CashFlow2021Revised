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
    public partial class frmMinorSection : Form
    {
        CashFlowBL CF = new CashFlowBL();
        int currentMinorSectionID=-1;
        string currentMinorSection=string.Empty;

        public frmMinorSection()
        {
            InitializeComponent();
        }

        private void frmMinorSection_Load(object sender, EventArgs e)
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
        }

        private void LoadMajorSections()
        {
            DataSet dsMajor = CF.GetMajorSections();
            cmbMajorSection.DataSource = dsMajor.Tables[0];
            cmbMajorSection.Refresh();
            cmbMajorSection.Text = "Select Major Section";
        }


        private void LoadMinorSections()
        {
            txtMinorSection.Text = "";
            DataSet dsMinor = CF.GetMinorSections(Convert.ToInt16(cmbMajorSection.SelectedValue));
            gridSections.DataSource = dsMinor.Tables[0];
            gridSections.Refresh();
            int lastPosition = Convert.ToInt16(dsMinor.Tables[1].Rows[0]["LASTPOSITION"]) + 10;
            txtPosition.Value = Convert.ToInt16(lastPosition);
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


            if (txtMinorSection.Text.Trim() == "")
                return;
            int duplicate = CF.CheckDuplicateMinorSection(txtMinorSection.Text.Trim());
            if (duplicate==1)
            {
                MessageBox.Show("Duplicate Minor Section", "Duplicate",  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            int j = CF.AddMinorSection(majorSectionID,txtMinorSection.Text.Trim(), Convert.ToInt16(txtPosition.Value));

            txtMinorSection.Text = "";
            LoadMinorSections();
            MessageBox.Show("Success !!", "Success", MessageBoxButtons.OK);
                
        }


        private void updateCurrentEntry()
        {
            if (txtMinorSection.Text.Trim() == "")
                return;
            if (currentMinorSection!=txtMinorSection.Text.Trim())
            {
                int duplicate = CF.CheckDuplicateMinorSection(txtMinorSection.Text.Trim());
                if (duplicate == 1)
                {
                    MessageBox.Show("Duplicate Minor Section", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);

            int j = CF.UpdateMinorSection(currentMinorSectionID,majorSectionID, txtMinorSection.Text.Trim(), Convert.ToInt16(txtPosition.Value));
            txtMinorSection.Text = "";
            LoadMinorSections();
            btnAdd.Text = "Add";
            MessageBox.Show("Success !!", "Success", MessageBoxButtons.OK);

        }


        private void cmbMajorSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int majorSectionID = Convert.ToInt16(cmbMajorSection.SelectedValue);
            DataSet dsMinor = new DataSet();
            dsMinor = CF.GetMinorSections(majorSectionID);
            gridSections.DataSource = dsMinor.Tables[0];
            gridSections.Refresh();
            int lastPosition = Convert.ToInt16(dsMinor.Tables[1].Rows[0]["LASTPOSITION"]) + 10;
            txtPosition.Value = lastPosition;
        }

        private void gridSections_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            var rowIndex = e.DataRow.RowIndex;
    
            var columnIndex = e.DataColumn.ColumnIndex;
         // var cellValue = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, e.DataColumn.GridColumn.MappingName);
            var cellValueID = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "MINORSECTIONID");
            var cellSectionValueID = this.gridSections.View.GetPropertyAccessProvider().GetValue(e.DataRow.RowData, "MINORSECTION");
            int minorSectionID = Convert.ToInt16(cellValueID);
            currentMinorSectionID = minorSectionID;
            currentMinorSection = Convert.ToString(cellSectionValueID);

            DataSet dsMinor = CF.GetMinorSectionsHavingMinorSectionID(minorSectionID);
            btnAdd.Text = "Update";
            cmbMajorSection.SelectedValue = Convert.ToInt16(dsMinor.Tables[0].Rows[0]["MajorSectionID"]);
        
            txtMinorSection.Text = Convert.ToString(dsMinor.Tables[0].Rows[0]["MinorSection"]);
            txtPosition.Value = Convert.ToInt16(dsMinor.Tables[0].Rows[0]["POSITION"]);
            btnDelete.Visible = true;

           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this entry ?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int j = CF.DeleteMinorSection(currentMinorSectionID);
                MessageBox.Show("Success !!!");
                btnAdd.Text = "Add";
                btnDelete.Visible = false;
                LoadMinorSections();
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
