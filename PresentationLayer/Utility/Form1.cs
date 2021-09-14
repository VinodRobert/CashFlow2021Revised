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
using Syncfusion.PivotAnalysis.Base;
namespace CashFlow.PresentationLayer
{
    public partial class Form1 : Form
    {
        DataSet ds;
        CashFlowBL CF = new CashFlowBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ds = CF.FetchCF();


            pivotGridControl1.ItemSource = ds.Tables[0];

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "FLOWCATEGORY", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "LEVEL1", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "LEVEL2", TotalHeader = "Total" });


            //// Adding PivotColumns to the Control
            //pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "TILLDATE", TotalHeader = "Total" });
            //pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "THISPERIOD", TotalHeader = "Total" });
            

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "TILLDATE",  SummaryType = SummaryType.DecimalTotalSum});
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "THISPERIOD", SummaryType = SummaryType.DecimalTotalSum });



        }
    }
}
