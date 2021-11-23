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
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;

namespace CashFlow 
{
    public partial class frmLC : Form
    {
        ClassFTR FTR = new ClassFTR();
        DataSet dsLC;
        int noProject = 1;
        int summaryRowAdded = 0;
        public frmLC()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetAll()
        {
            lblProjectName.Visible = false;
            btnFetch.Visible = false;
            
            btnClose.Visible = true;
            lblMonthName.Visible = false;
            
            gridLC.Visible = false;
        }


        private void frmLC_Load(object sender, EventArgs e)
        {
            ResetAll();
            PopulateProjects();
            if (noProject == 0)
                this.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            gridLC.DataSource = null;
            gridLC.Visible = false;
            lblMonthName.Text = "";
            gridLC.Refresh();
            if (cmbProject.Text == "Select Project")
                return;
            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
            dsLC = FTR.FetchLC(projectID, 0);
            gridLC.DataSource = dsLC.Tables[0];
            string lblUserInputPeriod = "For Period " + Convert.ToString(dsLC.Tables[1].Rows[0]["CALENDARMONTH"]) + " - " + Convert.ToString(dsLC.Tables[1].Rows[0]["CALENDARYEAR"]);
            lblMonthName.Text = lblUserInputPeriod;
            lblMonthName.Visible = true;
            this.gridLC.TableControl.RowHeights[2] = 50;
            gridLC.Columns[4].AllowTextWrapping = true;
            gridLC.Columns[1].AllowTextWrapping = true;
            gridLC.Columns[2].AllowTextWrapping = true;
            gridLC.Columns[3].AllowTextWrapping = true;
            gridLC.RowHeight = 50;



            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "Debit";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total : {Sum:c}";
            summaryColumn1.MappingName = "DEBIT";

            GridSummaryColumn summaryColumn2 = new GridSummaryColumn();
            summaryColumn2.Name = "Credit";
            summaryColumn2.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn2.Format = "Total : {Sum:c}";
            summaryColumn2.MappingName = "CREDIT";
            
           

            if (summaryRowAdded == 0)
            {
                tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
                tableSummaryRow1.SummaryColumns.Add(summaryColumn2);
                summaryRowAdded = 1;
                this.gridLC.TableSummaryRows.Add(tableSummaryRow1);
            }

            this.gridLC.Style.GroupSummaryRowStyle.BackColor = Color.LightSkyBlue;
            this.gridLC.Style.GroupSummaryRowStyle.Font = new GridFontInfo(new Font("Arial", 10f, FontStyle.Bold));
            


            gridLC.Visible = true;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            gridLC.DataSource = null;
            gridLC.Visible = false;
            lblMonthName.Text = "";
            gridLC.Refresh();
            if (cmbProject.Text == "Select Project")
                return;
            int projectID = Convert.ToInt16(cmbProject.SelectedValue);
            dsLC = FTR.FetchLC(projectID, 1);
            gridLC.DataSource = dsLC.Tables[0];
            string lblUserInputPeriod = "For Period Above " + Convert.ToString(dsLC.Tables[1].Rows[0]["CALENDARMONTH"]) + " - " + Convert.ToString(dsLC.Tables[1].Rows[0]["CALENDARYEAR"]);
            lblMonthName.Text = lblUserInputPeriod;
            lblMonthName.Visible = true;
            this.gridLC.TableControl.RowHeights[2] = 60;
            gridLC.Columns[4].AllowTextWrapping = true;
            gridLC.Columns[1].AllowTextWrapping = true;
            gridLC.Columns[2].AllowTextWrapping = true;
            gridLC.Columns[3].AllowTextWrapping = true;
            gridLC.RowHeight = 50;

            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "Debit";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total : {Sum:c}";
            summaryColumn1.MappingName = "DEBIT";

            GridSummaryColumn summaryColumn2 = new GridSummaryColumn();
            summaryColumn2.Name = "Credit";
            summaryColumn2.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn2.Format = "Total : {Sum:c}";
            summaryColumn2.MappingName = "CREDIT";



            if (summaryRowAdded == 0)
            {
                tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
                tableSummaryRow1.SummaryColumns.Add(summaryColumn2);
                summaryRowAdded = 1;
                this.gridLC.TableSummaryRows.Add(tableSummaryRow1);
            }

            this.gridLC.Style.GroupSummaryRowStyle.BackColor = Color.LightSkyBlue;
            this.gridLC.Style.GroupSummaryRowStyle.Font = new GridFontInfo(new Font("Arial", 10f, FontStyle.Bold));



            gridLC.Visible = true;

        }

        private void gridLC_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.LightGoldenrodYellow;
                else
                    e.Style.BackColor = Color.LightSalmon;
            }
        }
    }
}
