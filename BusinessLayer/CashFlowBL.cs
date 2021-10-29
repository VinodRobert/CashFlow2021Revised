using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashFlowSqlHelper;

namespace CashFlow.BusinessLayer
{
    class CashFlowBL
    {

        #region masters

        public DataSet FetchYears()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT DISTINCT YEAR FROM PERIODSETUP WHERE YEAR>=2018 AND ORGID=2 AND YEAR<=DATEPART(YEAR,GETDATE()) ORDER BY YEAR DESC ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
           
            return ds;
        }

        public DataSet FetchMonths()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT  number, DATENAME(MONTH, '1900-' + CAST(number as varchar(2)) + '-1') monthname FROM master..spt_values ";
            sql = sql + " WHERE Type = 'P' and number between 1 and 12 ORDER BY Number";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchZones()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT BSBORGID BORGID,BSBORGNAME BORGNAME FROM CFR.PROJECTS WHERE PARENTBORGID=-1 ORDER BY BSBORGID ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text,sql);
            return ds;
        }
        
        public DataSet FetchProjects(int zoneID) 
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT BSBORGID BORGID,BSBORGNAME BORGNAME FROM CFR.PROJECTS WHERE PARENTBORGID = " + Convert.ToString(zoneID);
            sql = sql + " AND CASHFLOWSTATUS='CashFlow'  ORDER BY BSBORGNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text,sql);
            return ds;
        }


        public DataSet FetchCF(int borgID,int finYear, int period)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[1].Value = finYear;
            arParms[2] = new SqlParameter("@THISPERIOD", SqlDbType.Int);
            arParms[2].Value = period;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CFR].[spProcessCashFlow]", arParms);
            return ds;
        }

       

        public int CheckDuplicateMajorSectionMaterial(string sectionName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select COUNT(*) ChkExists from CFR.MAJORMATERIALCATEGORY WHERE MajorCategory='" + Convert.ToString(sectionName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int duplicate = Convert.ToInt16(ds.Tables[0].Rows[0]["ChkExists"]);
            return duplicate;
        }

        public int CheckDuplicateMajorSection(string sectionName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select COUNT(*) ChkExists from CF.CFMajorSection WHERE MajorSection='" + Convert.ToString(sectionName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int duplicate = Convert.ToInt16(ds.Tables[0].Rows[0]["ChkExists"]);
            return duplicate;
        }

        public int CheckDuplicateMinorMaterialCateegory(string minorCategoryName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select COUNT(*) ChkExists from CFR.MINORMATERIALCATEGORY WHERE MinorCategory='" + Convert.ToString(minorCategoryName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int duplicate = Convert.ToInt16(ds.Tables[0].Rows[0]["ChkExists"]);
            return duplicate;
        }


        public int CheckDuplicateMinorSection(string sectionName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select COUNT(*) ChkExists from CF.CFMinorSection WHERE MinorSection='" + Convert.ToString(sectionName).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int duplicate = Convert.ToInt16(ds.Tables[0].Rows[0]["ChkExists"]);
            return duplicate;
        }


        public int CheckDuplicateDetails(string details)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select COUNT(*) ChkExists from CF.CFDetails WHERE Details='" + Convert.ToString(details).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int duplicate = Convert.ToInt16(ds.Tables[0].Rows[0]["ChkExists"]);
            return duplicate;
        }

        public int AddMajorSectionMaterial(string sectionName)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CFR.MAJORMATERIALCATEGORY(MajorCategory) VALUES ('" + Convert.ToString(sectionName).Trim() + "');";

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int AddMajorSection(string sectionName,int place)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CF.CFMajorSection(MajorSection,Position) VALUES ('"+Convert.ToString(sectionName).Trim()+"',"+Convert.ToString(place)+")";

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }
         
        public int AddMinorSection(int majorSectionID,string sectionName, int place)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CF.CFMinorSection(MajorSectionID,MinorSection,Position) VALUES (";
            sql = sql + Convert.ToString(majorSectionID)+",'"+ Convert.ToString(sectionName).Trim() + "'," + Convert.ToString(place) + ")";

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int AddDetails(int majorSectionID,int minorSectionID, string details, int place)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CF.CFDetails(MajorSectionID,MinorSectionID,Details,Position) VALUES (" + Convert.ToString(majorSectionID) + ",";
            sql = sql + Convert.ToString(minorSectionID) + ",'" + Convert.ToString(details).Trim() + "'," + Convert.ToString(place) + ")";

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }


        public int UpdateMinorSection(int minorSectionID,int majorSectionID,string sectionName, int place)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Update CF.CFMinorSection set majorSectionID=" + Convert.ToString(majorSectionID) + "  Where MinorSectionID=" + Convert.ToString(minorSectionID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update CF.CFMinorSection set minorSection='" + Convert.ToString(sectionName) + "'  Where MinorSectionID=" + Convert.ToString(minorSectionID);
            i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update CF.CFMinorSection set position=" + Convert.ToString(place) + "  Where MinorSectionID=" + Convert.ToString(minorSectionID);
            i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int UpdateDetails(int majorSectionID,int minorSectionID,int detailsID,string details,int place)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Update CF.CFDetails set majorSectionID=" + Convert.ToString(majorSectionID) + "  Where DetailsID=" + Convert.ToString(detailsID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update CF.CFDetails set minorSectionID=" + Convert.ToString(minorSectionID) + "  Where DetailsID=" + Convert.ToString(detailsID);
            i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update CF.CFDetails set details='" + Convert.ToString(details) + "'  Where DetailsID=" + Convert.ToString(detailsID);
            i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update CF.CFDetails set position=" + Convert.ToString(place) + "  Where DetailsID=" + Convert.ToString(detailsID);
            i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }   

        public int DeleteMinorSection(int minorSectionID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM  CF.CFMinorSection WHERE minorSectionID=" + Convert.ToString(minorSectionID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
           
            return 1;
        }
        public int DeleteDetails(int detailsID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM  CF.CFDETAILS WHERE DETAILSID=" + Convert.ToString(detailsID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);

            return 1;
        }

        public DataSet GetMajorMaterialCategory()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM CFR.MAJORMATERIALCATEGORY ORDER BY MAJORCATEGORY ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchMissingLedgerCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT L.LEDGERCODE,(L.LEDGERCODE+'  -  '+UPPER(L.LEDGERNAME))  LEDGERNAME FROM LEDGERCODES L "; 
            sql =  sql + " WHERE LEDGERCODE IN (SELECT DISTINCT EXPENSELEDGERCODE ";
            sql =  sql + " FROM CFR.TRANSSUMMARY WHERE PARTYCODE='' AND  EXPENSELEDGERCODE NOT IN (";
            sql =  sql + " SELECT LEDGERCODE FROM CFR.CFMARKER_LEDGERMAPPING )) ORDER BY LEDGERCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchMissingCreditorCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT C.CREDNUMBER PARTYCODE ,(C.CREDNUMBER+'  -  '+UPPER(C.CREDNAME))  PARTYNAME FROM CREDITORS C ";
            sql = sql + " WHERE CREDNUMBER  IN (SELECT DISTINCT PARTYCODE  ";
            sql = sql + " FROM CFR.TRANSSUMMARY WHERE  PARTYCODE NOT IN (";
            sql = sql + " SELECT VENDORCODE FROM CFR.CFMARKER_VENDORMAPPING WHERE VENDORTYPE=1 )) ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchMissingSubbieCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT S.SUBNUMBER PARTYCODE ,(S.SUBNUMBER+'  -  '+UPPER(S.SUBNAME))  PARTYNAME FROM SUBCONTRACTORS S ";
            sql = sql + " WHERE SUBNUMBER  IN (SELECT DISTINCT PARTYCODE  ";
            sql = sql + " FROM CFR.TRANSSUMMARY WHERE  PARTYCODE NOT IN (";
            sql = sql + " SELECT VENDORCODE FROM CFR.CFMARKER_VENDORMAPPING WHERE VENDORTYPE=2 )) ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchMappedLedgerCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT L.LEDGERCODE,(L.LEDGERCODE+'  -  '+UPPER(L.LEDGERNAME))  LEDGERNAME FROM LEDGERCODES L ";
            sql = sql + " WHERE LEDGERCODE IN ( SELECT LEDGERCODE FROM CFR.CFMARKER_LEDGERMAPPING ) ";
            sql = sql + " ORDER BY LEDGERCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchMappedCreditorCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT C.CREDNUMBER PARTYCODE ,(C.CREDNUMBER+'  -  '+UPPER(C.CREDNAME))  PARTYNAME FROM CREDITORS C ";
            sql = sql + " WHERE CREDNUMBER   IN ( SELECT VENDORCODE FROM CFR.CFMARKER_VENDORMAPPING WHERE VENDORTYPE=1 ) ";
            sql = sql + " ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchMappedSubbieCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT S.SUBNUMBER PARTYCODE ,(S.SUBNUMBER+'  -  '+UPPER(S.SUBNAME))  PARTYNAME FROM SUBCONTRACTORS S ";
            sql = sql + " WHERE SUBNUMBER   IN ( SELECT VENDORCODE FROM CFR.CFMARKER_VENDORMAPPING WHERE VENDORTYPE=2 ) ";
            sql = sql + " ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public void UpdateLedgerCodeWithCashFlowMarker(string ledger,string marker)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CFR.CFMARKER_LEDGERMAPPING VALUES ('" + Convert.ToString(marker).Trim() + "','" + Convert.ToString(ledger).Trim() + "')";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
        }

        public void UpdatePartyCodeWithCashFlowMarker(string partyCode, string marker, int partyType )
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CFR.CFMARKER_VENDORMAPPING VALUES ('" + Convert.ToString(marker).Trim() + "',";
            sql = sql + Convert.ToString(partyType)+",'" + Convert.ToString(partyCode).Trim() + "')";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
        }

        public void DeleteLedgerCodeWithCashFlowMarker(string ledger, string marker)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM CFR.CFMARKER_LEDGERMAPPING WHERE CASHFLOWMARKER='" + Convert.ToString(marker).Trim() + "' AND LEDGERCODE='" + Convert.ToString(ledger).Trim() + "'";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
        }

        public void DeletePartyCodeWithCashFlowMarker(string partyCode, string marker)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM CFR.CFMARKER_VENDORMAPPING WHERE STRUCTUREKEY='" + Convert.ToString(marker).Trim() + "' AND VENDORCODE='" + Convert.ToString(partyCode).Trim() + "'";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
        }

        public DataSet FetchCashFlowMappingForPartyCreditor()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT STRUCTUREKEY,FLOWCATEGORY,LEVEL1,LEVEL2 FROM CFR.CASHFLOWMARKERS WHERE POINTER='P'  AND LEVEL1<>'SUBCONTRACTOR' ORDER BY STRUCTUREKEY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCashFlowMappingForPartySubbie()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT STRUCTUREKEY,FLOWCATEGORY,LEVEL1,LEVEL2 FROM CFR.CASHFLOWMARKERS WHERE POINTER='P'  AND LEVEL1='SUBCONTRACTOR' ORDER BY STRUCTUREKEY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchCashFlowMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT STRUCTUREKEY,FLOWCATEGORY,LEVEL1,LEVEL2 FROM CFR.CASHFLOWMARKERS WHERE POINTER='L' ORDER BY STRUCTUREKEY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCurrentLedgerCashFlowMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT L.LEDGERCODE,UPPER(L.LEDGERNAME) LEDGERNAME,M.FLOWCATEGORY,M.LEVEL1,M.LEVEL2";
            sql = sql + " FROM LEDGERCODES L INNER JOIN CFR.CFMARKER_LEDGERMAPPING CFR ON L.LEDGERCODE = CFR.LEDGERCODE ";
            sql = sql + " INNER JOIN CFR.CASHFLOWMARKERS M ON CFR.CASHFLOWMARKER = M.STRUCTUREKEY WHERE M.POINTER = 'L' ";
            sql = sql + " ORDER BY L.LEDGERCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCurrentCreditorCashFlowMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT C.CREDNUMBER PARTYCODE,UPPER(C.CREDNAME) PARTYNAME,M.FLOWCATEGORY,M.LEVEL1,M.LEVEL2";
            sql = sql + " FROM CREDITORS C INNER JOIN CFR.CFMARKER_VENDORMAPPING CFR ON C.CREDNUMBER = CFR.VENDORCODE ";
            sql = sql + " INNER JOIN CFR.CASHFLOWMARKERS M ON CFR.STRUCTUREKEY = M.STRUCTUREKEY WHERE CFR.VENDORTYPE = 1 ";
            sql = sql + " ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchCurrentSubbieCashFlowMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT S.SUBNUMBER PARTYCODE,UPPER(S.SUBNAME) PARTYNAME,M.FLOWCATEGORY,M.LEVEL1,M.LEVEL2";
            sql = sql + " FROM SUBCONTRACTORS S INNER JOIN CFR.CFMARKER_VENDORMAPPING CFR ON S.SUBNUMBER = CFR.VENDORCODE ";
            sql = sql + " INNER JOIN CFR.CASHFLOWMARKERS M ON CFR.STRUCTUREKEY = M.STRUCTUREKEY WHERE CFR.VENDORTYPE = 2 ";
            sql = sql + " ORDER BY PARTYNAME ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetMajorSections()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM CF.CFMajorSection ORDER BY Position;Select ISNULL( MAX(POSITION),0) LASTPOSITION FROM CF.CFMajorSection";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetMinorMaterialCategory()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT MI.MINORCATEGORYID,MJ.MAJORCATEGORY,MI.MINORCATEGORY ";
            sql = sql + " FROM CFR.MINORMATERIALCATEGORY MI INNER JOIN CFR.MAJORMATERIALCATEGORY MJ ";
            sql = sql + " ON MJ.MAJORCATEGORYCODE = MI.MAJORCATEGORYID ";
            sql = sql + " ORDER BY MAJORCATEGORY,MINORCATEGORY ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet GetMinorMaterialCategory(int majorID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT MI.MINORCATEGORYID,MJ.MAJORCATEGORY,MI.MINORCATEGORY ";
            sql = sql + " FROM CFR.MINORMATERIALCATEGORY MI INNER JOIN CFR.MAJORMATERIALCATEGORY MJ ";
            sql = sql + " ON MJ.MAJORCATEGORYCODE = MI.MAJORCATEGORYID WHERE MI.MAJORCATEGORYID= "+Convert.ToString(majorID);
            sql = sql + " ORDER BY MAJORCATEGORY,MINORCATEGORY ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet GetMinorSections(int majorSectionID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT MA.MAJORSECTION,MI.MINORSECTIONID,MI.MINORSECTION,MI.POSITION FROM CF.CFMINORSECTION MI INNER JOIN[CF].[CFMAJORSECTION] MA ON MA.MAJORSECTIONID=MI.MAJORSECTIONID ";
            sql = sql + " WHERE MA.MAJORSECTIONID=" + Convert.ToString(majorSectionID)+" ORDER BY POSITION; Select ISNULL( MAX(POSITION),0) LASTPOSITION FROM CF.CFMinorSection";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public DataSet GetMinorSectionsHavingMinorSectionID(int minorSectionID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM CF.CFMINORSECTION WHERE MINORSECTIONID=" + Convert.ToString(minorSectionID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetDetails(int majorSectionID,int minorSectionID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT D.MajorSectionID,M.MajorSection,D.MinorSectionID,MI.MinorSection,D.DetailsID,D.Details,D.Position ";
            sql = sql + " FROM CF.CFDETAILS D INNER JOIN CF.CFMAJORSECTION M ON M.MAJORSECTIONID = D.MAJORSECTIONID ";
            sql = sql + " INNER JOIN CF.CFMINORSECTION MI ON MI.MINORSECTIONID = D.MINORSECTIONID ";
            sql = sql + " WHERE D.MAJORSECTIONID = " + Convert.ToString(majorSectionID) + "  AND D.MINORSECTIONID = " + Convert.ToString(minorSectionID);
            sql = sql + "; Select ISNULL( MAX(POSITION),0) LASTPOSITION FROM CF.CFDetails";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetDetailsHavingDetailsID(int detailsID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT * FROM CF.CFDETAILS WHERE DETAILSID=" + Convert.ToString(detailsID);
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


     
        public DataSet GetProjects()
        {
            string _connectionString = SqlHelper.GetConnectionString();

            string sql = "SELECT BSBORGID BORGID,BSBORGNAME BORGNAME FROM CFR.PROJECTS WHERE STATUSID=1 ORDER BY BSBORGNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text,sql);
            return ds;
        }

        public DataSet GetFinYears()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT DISTINCT YEAR FINYEAR FROM PERIODSETUP WHERE ORGID=2 AND YEAR>=2022";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetCurrents()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT CURRENTYEAR CURRENTFINYEAR,PERIOD CURRENTPERIOD FROM  BORGS WHERE BORGID=2";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet GetPeriods()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[BI].[spGetPeriod]");
            return ds;
        }

        public DataSet GetProfitLossValues(int borgID, int finYear, int period, int numberFormat)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[5];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[1].Value = finYear;
            arParms[2] = new SqlParameter("@PERIOD", SqlDbType.Int);
            arParms[2].Value = period;
            arParms[3] = new SqlParameter("@NUMBERFORMAT", SqlDbType.Int);
            arParms[3].Value = numberFormat;
            arParms[4] = new SqlParameter("@REPORTTYPE", SqlDbType.Int);
            arParms[4].Value = 0;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[spGenerateCashFlowValues]", arParms);
            return ds;
        }


        public DataSet GetCashFlowValues(int borgID,int finYear,int period,int numberFormat)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[5];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[1].Value = finYear;
            arParms[2] = new SqlParameter("@PERIOD", SqlDbType.Int);
            arParms[2].Value = period;
            arParms[3] = new SqlParameter("@NUMBERFORMAT", SqlDbType.Int);
            arParms[3].Value = numberFormat;
            arParms[4] = new SqlParameter("@REPORTTYPE", SqlDbType.Int);
            arParms[4].Value = 1;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[spGenerateCashFlowValues]", arParms);
            return ds;
        }

        public DataSet GetUserInputs(int borgID, int finYear, int period)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[1].Value = finYear;
            arParms[2] = new SqlParameter("@PERIOD", SqlDbType.Int);
            arParms[2].Value = period;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[PopulateUserInputValues]", arParms);
            return ds;
        }

        public int UpdateUserInput(int rowIndex,decimal priorPeriod,decimal currentPeriod,decimal nextPeriod,decimal nextToNextPeriod)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            int successCode;
            string sqlA = "UPDATE CF.USERINPUTS SET PRIORPERIOD=" + Convert.ToDecimal(priorPeriod) + " WHERE INDEXCODE=" + Convert.ToInt16(rowIndex);
            string sqlB = "UPDATE CF.USERINPUTS SET CURRENTPERIOD=" + Convert.ToDecimal(currentPeriod) + " WHERE INDEXCODE=" + Convert.ToInt16(rowIndex);
            string sqlC = "UPDATE CF.USERINPUTS SET NEXTMONTH=" + Convert.ToDecimal(nextPeriod) + " WHERE INDEXCODE=" + Convert.ToInt16(rowIndex);
            string sqlD = "UPDATE CF.USERINPUTS SET NEXTTONEXTMONTH=" + Convert.ToDecimal(nextToNextPeriod) + " WHERE INDEXCODE=" + Convert.ToInt16(rowIndex);


            successCode = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sqlA);
            successCode = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sqlB);
            successCode = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sqlC);
            successCode = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sqlD);
            return successCode;
        }

        public DataSet UnMappedLedgerCodes()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT LEDGERALLOC, LEDGERCODE,UPPER(LEDGERNAME) LEDGERNAME FROM LEDGERCODES ";
            sql = sql + " WHERE LEDGERCODE NOT IN(SELECT LEDGERCODE FROM CF.CASHFLOWLEDGERMAPPING) AND LEDGERSUMMARY = 0 ";
            sql = sql + " AND LEDGERSTATUS = 0 ORDER BY LEDGERCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet LedgerMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT 1 AS CHKSELECT,LI.CFCODE,LI.NARRATION,LM.LEDGERCODE,LM.LEDGERNAME,LM.VALUEPORTION  ";
            sql = sql + " FROM CF.CASHFLOWLINEITEMS LI INNER JOIN CF.CASHFLOWLEDGERMAPPING LM ON LI.CFCODE = LM.CFID  ORDER BY LI.POSITION ,LM.LEDGERCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet CashFlowLineItems()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT POSITION,CFCODE,NARRATION,CASE WHEN USERINPUT = 0  THEN ''  WHEN USERINPUT = 1  THEN 'User Input - Yes' ";
            sql = sql + "  END AS USERINPUT, FORMULA,REMARKS FROM CF.CASHFLOWLINEITEMS ORDER BY POSITION, CFCODE ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet CashFlowLineItemsMinimum()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT CFCODE, NARRATION FROM CF.CASHFLOWLINEITEMS WHERE FORMULA = '' ORDER BY POSITION";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        
        public DataSet LedgerMapping(string cfCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT  LEDGERCODE,LEDGERNAME FROM CF.CASHFLOWLEDGERMAPPING WHERE CFID='"+Convert.ToString(cfCode)+"' ORDER BY LEDGERCODE";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int UnMapLedgerCode(string cfCode,string ledgerCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM CF.CASHFLOWLEDGERMAPPING WHERE CFID='" + Convert.ToString(cfCode).Trim() + "' AND ";
            sql = sql + " LEDGERCODE='" + Convert.ToString(ledgerCode) + "'";
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public int MapLedgerCode(string cfCode, string ledgerCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "INSERT INTO CF.CASHFLOWLEDGERMAPPING(CFID,LEDGERCODE) ";
            sql = sql + " VALUES('" + Convert.ToString(cfCode).Trim()+ "','" + Convert.ToString(ledgerCode).Trim() + "')";
            int k = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "UPDATE CF.CASHFLOWLEDGERMAPPING SET LEDGERNAME=L.LEDGERNAME FROM LEDGERCODES L WHERE LEDGERCODE='";
            sql = sql + Convert.ToString(ledgerCode).Trim() + "'";
            int m = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "UPDATE CF.CASHFLOWLEDGERMAPPING SET VALUEPORTION='(Debit-Credit)',COLUMNPOSITION=0 WHERE CFID='" + Convert.ToString(cfCode) + "'";
            int n = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 1;
        }

        public DataSet  ValidateUserInput(int borgID, int finyear,int period)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[3];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@FINYEAR", SqlDbType.Int);
            arParms[1].Value = finyear;
            arParms[2] = new SqlParameter("@PERIOD", SqlDbType.Int);
            arParms[2].Value = period;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[ValidateUserInputValues]", arParms);
            return ds;
        }

        #endregion

        public DataSet FetchFTRWorkSheet(int borgID, int finyear,int period,int reCreate)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[4];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@CURRENTFINYEAR", SqlDbType.Int);
            arParms[1].Value = finyear;
            arParms[2] = new SqlParameter("@FORMONTH", SqlDbType.Int);
            arParms[2].Value = period;
            arParms[3] = new SqlParameter("@RECREATE", SqlDbType.Int);
            arParms[3].Value = reCreate;


            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "FTR.spFTRWorkSheet", arParms);
            return ds;
        }



        public DataSet FetchFTRCreditors(int borgID, int finyear)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@CURRENTFINYEAR", SqlDbType.Int);
            arParms[1].Value = finyear;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[spFTR_For_Creditor]", arParms);
            return ds;
        }


        public DataSet FetchFTRSubbie(int borgID, int finyear)
        {
            string _connectionString = SqlHelper.GetConnectionString();

            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@CURRENTFINYEAR", SqlDbType.Int);
            arParms[1].Value = finyear;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[CF].[spFTR_For_Subbie]", arParms);
            return ds;
        }

    }


}
