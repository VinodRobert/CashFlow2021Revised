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
    public partial class frmMajorSection : Form
    {
        CashFlowBL CF = new CashFlowBL();
        public frmMajorSection()
        {
            InitializeComponent();
        }

        private void frmMajorSection_Load(object sender, EventArgs e)
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
        }


        private void LoadMajorSections()
        {
            DataSet dsMajor = CF.GetMajorSections();
            gridSections.DataSource = dsMajor.Tables[0];
            gridSections.Refresh();
            int lastPosition = Convert.ToInt16(dsMajor.Tables[1].Rows[0]["LASTPOSITION"]) + 10;
            txtPosition.IntegerValue = lastPosition;
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
            if (txtMajorSection.Text.Trim() == "")
                return;
            int duplicate = CF.CheckDuplicateMajorSection(txtMajorSection.Text.Trim());
            if (duplicate==1)
            {
                MessageBox.Show("Duplicate Major Section", "Duplicate",  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int j = CF.AddMajorSection(txtMajorSection.Text.Trim(), Convert.ToInt16(txtPosition.IntegerValue));

            txtMajorSection.Text = "";
            LoadMajorSections();
            MessageBox.Show("Success !!", "Success", MessageBoxButtons.OK);
                
        }
    }
}
