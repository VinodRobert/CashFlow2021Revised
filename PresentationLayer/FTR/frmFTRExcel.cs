using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CashFlowSqlHelper;
using CashFlow.BusinessLayer;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO.Implementation.Collections;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Globalization;

namespace CashFlow 
{
    public partial class frmFTRExcel : Form
    {
        DataSet dsResult;
        ClassFTR FTR = new ClassFTR();
        string ExcelFileToStore;
        int ftrIDToExtract;

        public frmFTRExcel(int ftrID)
        {
            InitializeComponent();
            ftrIDToExtract = ftrID;
        }

        private void GenerateFileName()
        {
       //     string bsProjectCode = Convert.ToString(dsProjectDetails.Tables[0].Rows[0]["ProjectCode"]);
            string _directoryName = @"C:\MIS\ExcelFiles\";
            string _fileName = "WOMovement1";
      //          + Convert.ToString(bsProjectCode).Trim() + "_" + Convert.ToString(SelectedToolCode) + "_";
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            _fileName = _fileName + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xlsx";
            ExcelFileToStore = _fileName;
            string _ExcelFileName = "File Name : " + _directoryName + _fileName;
            lblFileName.Text = _ExcelFileName;
            lblFileName.Visible = true;
        }


        private void frmFTRExcel_Load(object sender, EventArgs e)
        {
            GenerateFileName();
            dsResult = FTR.GetFTRExcel(ftrIDToExtract);

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;

                application.DefaultVersion = ExcelVersion.Excel2016;

                //Create a workbook
                IWorkbook workbook = application.Workbooks.Create(2);
                IWorksheet worksheet = workbook.Worksheets[1];
                IWorksheet summarysheet = workbook.Worksheets[0];

                //IStyle periodstyleA = workbook.Styles.Add("NewStyleA");
                ////periodstyleA.Color = Color.FromArgb(240, 12, 127);
                ////periodstyleA.Font.Color = ExcelKnownColors.White;
                //periodstyleA.Font.Bold = true;
                //periodstyleA.HorizontalAlignment = ExcelHAlign.HAlignCenter;

                //IStyle periodstyleB = workbook.Styles.Add("NewStyleB");
                ////periodstyleB.Color = Color.FromArgb(240, 132, 127);
                ////periodstyleB.Font.Color = ExcelKnownColors.White;
                //periodstyleB.Font.Bold = true;
                //periodstyleB.HorizontalAlignment = ExcelHAlign.HAlignCenter;



                worksheet.Name = "Work Sheet";

                //Adding a picture
                //FileStream imageStream = new FileStream("Capacite.png", FileMode.Open, FileAccess.Read);
               // IPictureShape shape = worksheet.Pictures.AddPicture(1, 1, imageStream, 100, 100);

                //Disable gridlines in the worksheet
                worksheet.IsGridLinesVisible = true;

       
                worksheet.Range["A1"].Text = "Capacitˡe Infraprojects Limited ";
                worksheet.Range["A1"].CellStyle.Font.Bold = true;
                worksheet.Range["A1"].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);
                worksheet.Range["A1:O1"].Merge();
                worksheet.Range["A1:O1"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                worksheet.Range["A1"].CellStyle.Font.FontName = "Arial";
                worksheet.Range["A1"].CellStyle.Font.Size = 20;

                worksheet.Range["A2"].Text = "Fund Transfer Requisition";
                worksheet.Range["A2"].CellStyle.Font.Bold = true;
                worksheet.Range["A2"].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);
                worksheet.Range["A2:O2"].Merge();
                worksheet.Range["A2:O2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                worksheet.Range["A2"].CellStyle.Font.FontName = "Arial";
                worksheet.Range["A2"].CellStyle.Font.Size = 15;

                worksheet.Range["A3"].Text = "Project";
                worksheet.Range["B3"].Text = "FTR Number ";
                worksheet.Range["A3:B3"].CellStyle.Font.Bold = true;
                worksheet.Range["A4"].Text = Convert.ToString(dsResult.Tables[1].Rows[0]["BORGNAME"]);
                worksheet.Range["A4"].CellStyle.Font.Bold = true;
                worksheet.Range["A4"].CellStyle.Color = Color.FromArgb(253, 14, 238);
                worksheet.Range["B4"].Text = Convert.ToString(dsResult.Tables[1].Rows[0]["FTRNUMBER"]);
                worksheet.Range["B4"].CellStyle.Color = Color.FromArgb(253, 14, 238);
                worksheet.Range["B4"].CellStyle.Font.Bold = true;
                worksheet.Range["A4:B4"].CellStyle.Font.FontName = "Arial";
                worksheet.Range["A4:B4"].CellStyle.Font.Size = 10;
                worksheet.Range["A4:B4"].CellStyle.Font.Color = ExcelKnownColors.White;
             
               

                worksheet.Range["A5"].Text = "Major Category";
                worksheet.Range["A5"].ColumnWidth = 35;

                worksheet.Range["B5"].Text = "Minor Category";
                worksheet.Range["B5"].ColumnWidth = 40;


                worksheet.Range["C5"].Text = "Category";
                worksheet.Range["C5"].ColumnWidth = 30;

                worksheet.Range["D5"].Text = "Party Code";
                worksheet.Range["D5"].ColumnWidth = 15;

                worksheet.Range["E5"].Text = "Party Name  ";
                worksheet.Range["E5"].ColumnWidth = 55;

                worksheet.Range["F5"].Text = "UpTo Date Gross Payable: (A)";
                worksheet.Range["F5"].WrapText = true;
                worksheet.Range["F5"].ColumnWidth = 15;
                

                worksheet.Range["G5"].Text = "Total Paid Upto Date: (B)";
                worksheet.Range["G5"].WrapText = true;
                worksheet.Range["G5"].ColumnWidth = 15;

                worksheet.Range["H5"].Text = "Balance Payable Site: C=(A-B)";
                worksheet.Range["H5"].WrapText = true; 
                worksheet.Range["H5"].ColumnWidth = 15;

                worksheet.Range["I5"].Text = "GST Credit: (D)";
                worksheet.Range["I5"].ColumnWidth = 15;
                worksheet.Range["I5"].WrapText = true;

                worksheet.Range["J5"].Text = "Balance at Company Level: (E)";
                worksheet.Range["J5"].WrapText = true;
                worksheet.Range["J5"].ColumnWidth = 15;

                worksheet.Range["K5"].Text = "Amount Payable After GST: F=(E-D)";
                worksheet.Range["K5"].ColumnWidth = 15;
                worksheet.Range["K5"].WrapText = true;

                worksheet.Range["L5"].Text = "Net Payable: MIN(F,C) ";
                worksheet.Range["L5"].WrapText = true;
                worksheet.Range["L5"].ColumnWidth = 15;

                worksheet.Range["M5"].Text = "Mob Advance Company Level";
                worksheet.Range["M5"].ColumnWidth = 15;
                worksheet.Range["M5"].WrapText = true;

                worksheet.Range["N5"].Text = "Payable-Site Recommended";
                worksheet.Range["N5"].WrapText = true;
                worksheet.Range["N5"].ColumnWidth = 15;

                worksheet.Range["O5"].Text = "Payable-Final Recommended";
                worksheet.Range["O5"].ColumnWidth = 15;
                worksheet.Range["O5"].WrapText = true;

                worksheet.Range["A5:O5"].RowHeight = 35;
                worksheet.Range["A5:O5"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                worksheet.Range["A5:O5"].CellStyle.Font.FontName = "Arial";
                worksheet.Range["A5:O5"].CellStyle.Font.Size = 12;

                int rowCount = Convert.ToInt16(dsResult.Tables[0].Rows.Count);
                string headerRange;
                string majorCategory;
                string minorCategory;
                string category;
                string partyCode;
                string partyName;
                decimal netPayable;
                decimal paid;
                decimal projectLiability;
                decimal gstCredit;
                decimal companyLiability;
                decimal payableAfterGST;
                decimal payable;
                decimal mobAdvance;
                decimal projectSite;
                decimal payableRecommended;

               
                int startRow = 6;
                string tableRange;
                for (int i = 0; i <= rowCount - 1; i++)
                {
                    majorCategory = Convert.ToString(dsResult.Tables[0].Rows[i]["MAJORCATEGORY"]);
                    minorCategory = Convert.ToString(dsResult.Tables[0].Rows[i]["MINORCATEGORY"]);
                    category = Convert.ToString(dsResult.Tables[0].Rows[i]["CATEGORY"]);
                    partyCode = Convert.ToString(dsResult.Tables[0].Rows[i]["PARTYCODE"]);
                    partyName = Convert.ToString(dsResult.Tables[0].Rows[i]["PARTYNAME"]);
                   

                    netPayable = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["NETPAYABLE"]);
                    paid = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PAID"]);
                    projectLiability = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PROJECTLIABILITY"]);
                    gstCredit = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["GSTCREDIT"]);
                    companyLiability = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["COMPANYLIABILITY"]);
                    payableAfterGST = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PAYABLEAFTERGST"]);
                    payable = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PAYABLE"]);
                    mobAdvance = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["MOBADVANCE"]);
                    projectSite = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PROJECTSITE"]);
                    payableRecommended = Convert.ToDecimal(dsResult.Tables[0].Rows[i]["PAYABLERECOMMENDED"]);


                    worksheet.Range["A" + Convert.ToString(startRow)].Text = Convert.ToString(majorCategory).Trim(); ;
                    worksheet.Range["B" + Convert.ToString(startRow)].Text = Convert.ToString(minorCategory).Trim();
                    worksheet.Range["C" + Convert.ToString(startRow)].Text = Convert.ToString(category).Trim();
                    worksheet.Range["D" + Convert.ToString(startRow)].Text = Convert.ToString(partyCode).Trim(); ;
                    worksheet.Range["E" + Convert.ToString(startRow)].Text = Convert.ToString(partyName).Trim();
           

                    worksheet.Range["F" + Convert.ToString(startRow)].Number = Convert.ToDouble(netPayable);
                    worksheet.Range["G" + Convert.ToString(startRow)].Number = Convert.ToDouble(paid);
                    worksheet.Range["H" + Convert.ToString(startRow)].Number = Convert.ToDouble(projectLiability);
                    worksheet.Range["I" + Convert.ToString(startRow)].Number = Convert.ToDouble(gstCredit);
                    worksheet.Range["J" + Convert.ToString(startRow)].Number = Convert.ToDouble(companyLiability);
                    worksheet.Range["K" + Convert.ToString(startRow)].Number = Convert.ToDouble(payableAfterGST);
                    worksheet.Range["L" + Convert.ToString(startRow)].Number = Convert.ToDouble(payable);
                    worksheet.Range["M" + Convert.ToString(startRow)].Number = Convert.ToDouble(mobAdvance);
                    worksheet.Range["N" + Convert.ToString(startRow)].Number = Convert.ToDouble(projectSite);
                    worksheet.Range["O" + Convert.ToString(startRow)].Number = Convert.ToDouble(payableRecommended);
                    startRow = startRow + 1;
                }

                tableRange = "F6:F"+ Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "G6:G" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "H6:H" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "I6:I" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "J6:J" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "K6:K" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "L6:L" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "M6:M" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "N6:N" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "O6:O" + Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                worksheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "A5:O"+ Convert.ToString(rowCount+5);
                worksheet.Range[tableRange].CellStyle.Font.FontName = "Arial";
                worksheet.Range[tableRange].CellStyle.Font.Size = 9;

                tableRange = "A6:O" + Convert.ToString(rowCount + 5);
                worksheet.Range[tableRange].RowHeight = 20;

                tableRange = "A5:O" + Convert.ToString(rowCount+5);
                IListObject table = worksheet.ListObjects.Create("Table1", worksheet[tableRange]);

                //Formatting table with a built-in style
                table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium9;


                int lastRowCount = rowCount + 6;
                tableRange = "A" + Convert.ToString(lastRowCount + 2);
                string lastUpdateTime = "FTR Last Update At :" + Convert.ToDateTime(dsResult.Tables[1].Rows[0]["LASTUPDATE"].ToString());
                worksheet.Range[tableRange].Text = lastUpdateTime;
                worksheet.Range[tableRange].CellStyle.Font.Bold = true;
                worksheet.Range[tableRange].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);

                tableRange = "B" + Convert.ToString(lastRowCount + 2);
                DateTime now = DateTime.Now;

                string strTodayFR = now.ToString("F");
                string reportGenerated = "Report Generated  At :" + Convert.ToString(strTodayFR);
                worksheet.Range[tableRange].Text = reportGenerated;
                worksheet.Range[tableRange].CellStyle.Font.Bold = true;
                worksheet.Range[tableRange].CellStyle.Font.RGBColor = Color.FromArgb(42, 166, 109);

                //Save the Excel document



                summarysheet.Name = "Summary";

                //Adding a picture
                //FileStream imageStream = new FileStream("Capacite.png", FileMode.Open, FileAccess.Read);
                // IPictureShape shape = summarysheet.Pictures.AddPicture(1, 1, imageStream, 100, 100);

                //Disable gridlines in the summarysheet
                summarysheet.IsGridLinesVisible = true;


                summarysheet.Range["A1"].Text = "Capacitˡe Infraprojects Limited ";
                summarysheet.Range["A1"].CellStyle.Font.Bold = true;
                summarysheet.Range["A1"].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);
                summarysheet.Range["A1:F1"].Merge();
                summarysheet.Range["A1:F1"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                summarysheet.Range["A1"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["A1"].CellStyle.Font.Size = 20;

                summarysheet.Range["A2"].Text = "Fund Transfer Requisition";
                summarysheet.Range["A2"].CellStyle.Font.Bold = true;
                summarysheet.Range["A2"].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);
                summarysheet.Range["A2:F2"].Merge();
                summarysheet.Range["A2:F2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                summarysheet.Range["A2"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["A2"].CellStyle.Font.Size = 15;

                string projectName= "Project : "+ Convert.ToString(dsResult.Tables[1].Rows[0]["BORGNAME"]);
                summarysheet.Range["A3"].Text = projectName;
                summarysheet.Range["A3:B3"].Merge();

                string ftrPeriod = "Period - "+ Convert.ToString(dsResult.Tables[1].Rows[0]["CALENDARMONTH"]);
                ftrPeriod=ftrPeriod + " - Year "+ Convert.ToString(dsResult.Tables[1].Rows[0]["CALENDARYEAR"]);

                summarysheet.Range["A5"].Text = ftrPeriod;
                summarysheet.Range["A5:B5"].Merge();

                string frtNumber="FTR Number : " + Convert.ToString(dsResult.Tables[1].Rows[0]["FTRNUMBER"]);
                summarysheet.Range["E5"].Text = frtNumber;
                summarysheet.Range["E5:F5"].Merge();

              
                summarysheet.Range["A3"].CellStyle.Color = Color.FromArgb(253, 14, 238);
                summarysheet.Range["A3"].CellStyle.Font.Bold = true;
                summarysheet.Range["A3"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["A3"].CellStyle.Font.Size = 12;
                summarysheet.Range["A3"].CellStyle.Font.Color = ExcelKnownColors.White;

                summarysheet.Range["A5"].CellStyle.Color = Color.FromArgb(253, 14, 238);
                summarysheet.Range["A5"].CellStyle.Font.Bold = true;
                summarysheet.Range["A5"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["A5"].CellStyle.Font.Size = 12;
                summarysheet.Range["A5"].CellStyle.Font.Color = ExcelKnownColors.White;

                summarysheet.Range["E5"].CellStyle.Color = Color.FromArgb(253, 14, 238);
                summarysheet.Range["E5"].CellStyle.Font.Bold = true;
                summarysheet.Range["E5"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["E5"].CellStyle.Font.Size = 12;
                summarysheet.Range["E5"].CellStyle.Font.Color = ExcelKnownColors.White;







                summarysheet.Range["A8"].Text = "Serial No";
                summarysheet.Range["A8"].ColumnWidth = 15;

                summarysheet.Range["B8"].Text = "Description";
                summarysheet.Range["B8"].ColumnWidth = 50;

                summarysheet.Range["C7:D7"].Text = "Up To Date";
                summarysheet.Range["C7:D7"].Merge();
                summarysheet.Range["C7"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                summarysheet.Range["C8"].Text = "Gross Payable";
                summarysheet.Range["C8"].WrapText = true;
                summarysheet.Range["C8"].ColumnWidth = 25;


                summarysheet.Range["D8"].Text = "Total Paid";
                summarysheet.Range["D8"].WrapText = true;
                summarysheet.Range["D8"].ColumnWidth = 25;


                summarysheet.Range["E7:F7"].Text = "Current FTR Period";
                summarysheet.Range["E7:F7"].Merge();
                summarysheet.Range["E7"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                summarysheet.Range["E8"].Text = "Net Payable";
                summarysheet.Range["E8"].WrapText = true;
                summarysheet.Range["E8"].ColumnWidth = 25;

       
                summarysheet.Range["F8"].Text = "Payment Recommended";
                summarysheet.Range["F8"].ColumnWidth = 25;
                summarysheet.Range["F8"].WrapText = true;

                summarysheet.Range["A8:F8"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                summarysheet.Range["A7:F8"].CellStyle.Font.FontName = "Arial";
                summarysheet.Range["A7:F8"].CellStyle.Font.Size = 12;
                summarysheet.Range["A7:F8"].CellStyle.Color = Color.FromArgb(213, 114, 138);
                summarysheet.Range["A7:F8"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;


                startRow = 9;
                rowCount = Convert.ToInt16(dsResult.Tables[2].Rows.Count);
                for (int i = 0; i <= rowCount - 1; i++)
                {
                    majorCategory = Convert.ToString(dsResult.Tables[2].Rows[i]["SERIALNO"]);
                    minorCategory = Convert.ToString(dsResult.Tables[2].Rows[i]["DESCRIPTION"]);
                    netPayable = Convert.ToDecimal(dsResult.Tables[2].Rows[i]["SUMNETPAYABLE"]);
                    paid = Convert.ToDecimal(dsResult.Tables[2].Rows[i]["SUMPAID"]);
                    payable = Convert.ToDecimal(dsResult.Tables[2].Rows[i]["SUMPAYABLE"]);
                    payableRecommended = Convert.ToDecimal(dsResult.Tables[2].Rows[i]["SUMPAYABLERECOMMENDED"]);


                    summarysheet.Range["A" + Convert.ToString(startRow)].Text = Convert.ToString(majorCategory).Trim(); ;
                    summarysheet.Range["B" + Convert.ToString(startRow)].Text = Convert.ToString(minorCategory).Trim();
                  
                    summarysheet.Range["C" + Convert.ToString(startRow)].Number = Convert.ToDouble(netPayable);
                    summarysheet.Range["D" + Convert.ToString(startRow)].Number = Convert.ToDouble(paid);
                    summarysheet.Range["E" + Convert.ToString(startRow)].Number = Convert.ToDouble(payable);
                    summarysheet.Range["F" + Convert.ToString(startRow)].Number = Convert.ToDouble(payableRecommended);
                    startRow = startRow + 1;
                }

                tableRange = "C9:C" + Convert.ToString(rowCount + 5);
                summarysheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                summarysheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "D9:D" + Convert.ToString(rowCount + 5);
                summarysheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                summarysheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "E9:E" + Convert.ToString(rowCount + 5);
                summarysheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                summarysheet.Range[tableRange].NumberFormat = "0.00";

                tableRange = "F9:F" + Convert.ToString(rowCount + 5);
                summarysheet.Range[tableRange].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignRight;
                summarysheet.Range[tableRange].NumberFormat = "0.00";
            
                tableRange = "A9:F" + Convert.ToString(rowCount + 5);
                          
               
                headerRange = "A9:B9";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                tableRange = "C9:F9";
                summarysheet.Range[tableRange].Text = "";

                headerRange = "A19:B19";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                tableRange = "C19:F19";
                summarysheet.Range[tableRange].Text = "";

                headerRange = "A24:B24";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                tableRange = "C24:F24";
                summarysheet.Range[tableRange].Text = "";

                headerRange = "A31:B31";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                tableRange = "C31:F31";
                summarysheet.Range[tableRange].Text = "";


                headerRange = "A37:B37";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                tableRange = "C37:F37";
                summarysheet.Range[tableRange].Text = "";

                headerRange = "A46:B46";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                tableRange = "C46:F46";
                summarysheet.Range[tableRange].Text = "";


                headerRange = "A52:B52";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                tableRange = "C52:F52";
                summarysheet.Range[tableRange].Text = "";


                headerRange = "A56:B56";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                tableRange = "C56:F56";
                summarysheet.Range[tableRange].Text = "";


                headerRange = "A68:F68";
                summarysheet.Range["B68"].Text = "Grand Total";
                summarysheet.Range[headerRange].CellStyle.Font.Bold = true;
                summarysheet.Range[headerRange].CellStyle.Font.FontName = "Arial";
                summarysheet.Range[headerRange].CellStyle.Font.Size = 12;
                summarysheet.Range[headerRange].NumberFormat = "0.00";



                lastRowCount = rowCount + 10;
                tableRange = "B" + Convert.ToString(lastRowCount + 10);
                summarysheet.Range[tableRange].Text = lastUpdateTime;
                summarysheet.Range[tableRange].CellStyle.Font.Bold = true;
                summarysheet.Range[tableRange].CellStyle.Font.RGBColor = Color.FromArgb(42, 118, 189);

                tableRange = "B" + Convert.ToString(lastRowCount + 11);

                summarysheet.Range[tableRange].Text = reportGenerated;
                summarysheet.Range[tableRange].CellStyle.Font.Bold = true;
                summarysheet.Range[tableRange].CellStyle.Font.RGBColor = Color.FromArgb(42, 166, 109);

               


                string fileName = "";
                fileName = ExcelFileToStore;
                workbook.Version = ExcelVersion.Excel2016;
                workbook.SaveAs(fileName);
                workbook.Close();
                excelEngine.Dispose();
                Process.Start(fileName);



            }

            this.Close();
        }
    }
}
    

