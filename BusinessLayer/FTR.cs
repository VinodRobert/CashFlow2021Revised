using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CashFlowSqlHelper;

namespace CashFlow.BusinessLayer
{
    class ClassFTR
    {
        #region Login
        public DataSet Login(string loginID, string password)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT BSLOGINID,BSLOGINNAME,ROLEID FROM FTR.FTRUSERS WHERE BSLOGINID='" + Convert.ToString(loginID).Trim() + "' AND BSPASSWORD = '";
            sql = sql + Convert.ToString(password).Trim() + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        #endregion



        #region UserInput
        public DataSet FetchLedgerMapping()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT ST.LINEORDER,UPPER(ST.DESCRIPTION) DESCRIPTION , LM.LEDGERCODE,UPPER(L.LEDGERNAME) LEDGERNAME  ";
            sql = sql + " FROM FTR.SUMMARYTEMPLATE ST INNER JOIN FTR.LEDGERMAPPING LM ON ST.CODE = LM.SUMMARYCODE ";
            sql = sql + " INNER JOIN LEDGERCODES L ON LM.LEDGERCODE = L.LEDGERCODE ORDER BY ST.LINEORDER  ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }
        public DataSet FetchLC(int projectID,int criteria)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = projectID;
            arParms[1] = new SqlParameter("@FUTUREPERIOD", SqlDbType.Int);
            arParms[1].Value = criteria;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[FTR].[spFetchLCDetails]", arParms);
            return ds;
        }


        public DataSet FetchProjectsForUserInputs(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT P.BSBORGID BORGID,P.BSBORGNAME BORGNAME FROM FTR.PROJECTS P WHERE BSBORGID IN ";
            sql = sql + " (SELECT BORGID FROM FTR.FTRHEADER WHERE FTRSTATUS = 0 AND OWNER = '" + Convert.ToString(loginID).Trim() + "')";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchUserInputs(int projectID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            int ftrMonthID = 0;
            string calendarYear;
            string sql = "SELECT CALENDARMONTHID,CALENDARYEAR  FROM FTR.FTRHEADER WHERE BORGID=" + Convert.ToString(projectID) + "  AND FTRSTATUS=0";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            ftrMonthID = Convert.ToInt16(ds.Tables[0].Rows[0]["CALENDARMONTHID"]);
            calendarYear = Convert.ToString(ds.Tables[0].Rows[0]["CALENDARYEAR"]);

            sql = "SELECT COUNT(*) COUNTS FROM FTR.USERINPUTS WHERE BORGID=" + Convert.ToString(projectID) + "  AND FTRMONTHID = (";
            sql = sql + " SELECT CALENDARMONTHID  FROM FTR.FTRHEADER WHERE BORGID = " + Convert.ToString(projectID) + "  AND FTRSTATUS = 0)";
            ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int existing = Convert.ToInt16(ds.Tables[0].Rows[0]["COUNTS"]);
            if (existing==0)
            {
                sql = "INSERT INTO FTR.USERINPUTS(BORGID,FTRMONTHID,DESCRIPTION,AMOUNT,SECTION,SUMMARYCODE,FTRCALENDARYEAR) ";
                sql = sql + "SELECT " + Convert.ToString(projectID) + "," + Convert.ToString(ftrMonthID) + ",DESCRIPTION,0,SECTION,SUMMARYCODE,";
                sql = sql + Convert.ToString(calendarYear)+  " FROM FTR.USERINPUTSMASTER";
                int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            }
            sql = "SELECT INPUTID,DESCRIPTION,AMOUNT from FTR.USERINPUTS WHERE SECTION=1 AND BORGID=" + Convert.ToString(projectID) + " AND FTRMONTHID=" + Convert.ToString(ftrMonthID) + ";  ";
            sql = sql + "SELECT INPUTID,DESCRIPTION,AMOUNT from FTR.USERINPUTS WHERE SECTION=2 AND BORGID=" + Convert.ToString(projectID) + " AND FTRMONTHID=" + Convert.ToString(ftrMonthID) + ";  ";
            sql = sql + "SELECT INPUTID,DESCRIPTION,AMOUNT from FTR.USERINPUTS WHERE SECTION=3 AND BORGID=" + Convert.ToString(projectID) + " AND FTRMONTHID=" + Convert.ToString(ftrMonthID) + ";  ";
            sql = sql + "SELECT CALENDARYEAR,CALENDARMONTH FROM FTR.FTRHEADER WHERE BORGID=" + Convert.ToString(projectID) + " AND FTRSTATUS=0";
            ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }


        public int UpdateUserInputs(int rowID,decimal amount)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "UPDATE FTR.USERINPUTS SET AMOUNT=" + Convert.ToString(amount) + " WHERE INPUTID = " + Convert.ToString(rowID);
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return 0;
        }


        #endregion
        #region FTR List

        public DataSet FetchDetailsForNewFTR(int projID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = projID;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "FTR.FetchDetailsForNewFTR", arParms);
            return ds;

        }


        public DataSet GetProjectsForFTR(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@LOGINID", SqlDbType.Text);
            arParms[0].Value = loginID;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[FTR].[spProjectForFTR]", arParms);
            return ds;
        }

        public DataSet GetFTRHistory(string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@LOGINID", SqlDbType.Text);
            arParms[0].Value = loginID;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[FTR].[spGetFTRHistory]", arParms);
            return ds;
        }

        public DataSet GetFTRID(int borgID)
        {
            string sql = "SELECT FTRID FROM FTR.FTRHEADER WHERE BORGID=" + Convert.ToString(borgID) + "  AND FTRSTATUS=0";
            string _connectionString = SqlHelper.GetConnectionString();
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int GenerateFTRHeader(int borgID,int calYear, int calMonth,string owner)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[4];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@CALYEAR", SqlDbType.Int);
            arParms[1].Value = calYear;
            arParms[2] = new SqlParameter("@CALMONTH", SqlDbType.Int);
            arParms[2].Value = calMonth;
            arParms[3] = new SqlParameter("@OWNER", SqlDbType.Text);
            arParms[3].Value = owner;
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "FTR.spCreateFTRHeader", arParms);
            return i;
        }

        public DataSet GenerateFTR(int borgID, int headerAlso)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            arParms[1] = new SqlParameter("@HEADERALSO", SqlDbType.Int);
            arParms[1].Value = headerAlso;

            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "FTR.spFTRWorkSheet", arParms);
            return ds;
        }
        #endregion

        #region Extract FTR Details To Present in WorkSheet
        public DataSet GetFTRWorkSheet(int ftrIDToExtract)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@FTRID", SqlDbType.Int);
            arParms[0].Value = ftrIDToExtract;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "FTR.spFTRWorkSheet", arParms);
            return ds;
        }

        public DataSet GetFTRExcel(int ftrIDToExtract)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@FTRID", SqlDbType.Int);
            arParms[0].Value = ftrIDToExtract;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "[FTR].[spFTRExport]", arParms);
            return ds;
        }


        #endregion


        #region Payment Recommendations Update

        //public void UpdatePaymentRecommendations(DataTable dt)
        //{
        //    string _connectionString = SqlHelper.GetConnectionString();
        //    using (SqlConnection con = new SqlConnection(_connectionString))
        //    {
        //        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
        //        {
        //            //Set the database table name
        //            sqlBulkCopy.DestinationTableName = "FTR.FTRAMOUNTAPPROVED";

        //            //[OPTIONAL]: Map the DataTable columns with that of the database table
        //            sqlBulkCopy.ColumnMappings.Add("Id", "CustomerId");
        //            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
        //            sqlBulkCopy.ColumnMappings.Add("Country", "Country");
        //            con.Open();
        //            sqlBulkCopy.WriteToServer(dt);
        //            con.Close();
        //        }
        //    }
        //}
        #endregion




        #region Mapping/UnMapping

        public DataSet getPartiesForMapping(int vendorType, int mappingType)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[2];
            arParms[0] = new SqlParameter("@VENDORTYPEID", SqlDbType.Int);
            arParms[0].Value = vendorType;
            arParms[1] = new SqlParameter("@MAPPINGID", SqlDbType.Int);
            arParms[1].Value = mappingType;
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.StoredProcedure, "FTR.spFetchPartiesForMapping", arParms);
            return ds;
        }

        public DataSet getMajorCategory(int vendorTypeID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT DISTINCT  MAJORCATEGORY  FROM FTR.MAPPINGMASTER WHERE VENDORTYPEID = " + Convert.ToString(vendorTypeID) + " ORDER BY MAJORCATEGORY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet getMinorCategory(int vendorTypeID, string majorCategory)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql;
            if (vendorTypeID == 1)
                sql = "SELECT DISTINCT MINORCATEGORY AS MAPPINGID, MINORCATEGORY  FROM FTR.MAPPINGMASTER WHERE MAJORCATEGORY ='" + Convert.ToString(majorCategory) + "' ORDER BY MINORCATEGORY";
            else
                sql = "SELECT DISTINCT MAPPINGID,MINORCATEGORY FROM FTR.MAPPINGMASTER WHERE MAJORCATEGORY='" + Convert.ToString(majorCategory) + "' ORDER BY MINORCATEGORY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet getCategory(string minorCategory)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT DISTINCT MAPPINGID,CATEGORY  FROM FTR.MAPPINGMASTER WHERE MINORCATEGORY ='" + Convert.ToString(minorCategory) + "' ORDER BY CATEGORY";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int InsertMapping(int vendorTypeID, string partyCodeForUpdate, int mappingID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql;
            if (vendorTypeID == 1)
                sql = "INSERT INTO FTR.MASTERCREDITOR(VENDORCODE,MAPPINGID) VALUES ('" + Convert.ToString(partyCodeForUpdate) + "'," + Convert.ToString(mappingID) + ")";
            else
                sql = "INSERT INTO FTR.MASTERSUBBIE(VENDORCODE,MAPPINGID) VALUES ('" + Convert.ToString(partyCodeForUpdate) + "'," + Convert.ToString(mappingID) + ")";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "DELETE FROM FTR.UNKNOWNPARTIES WHERE PARTYCODE='" + Convert.ToString(partyCodeForUpdate) + "'";
            j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return j;
        }

        public int UpdateMapping(int vendorTypeID, string partyCodeForUpdate, int mappingID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql;
            if (vendorTypeID == 1)
                sql = "UPDATE FTR.MASTERCREDITOR SET MAPPINGID=" + Convert.ToString(mappingID) + " WHERE VENDORCODE='" + Convert.ToString(partyCodeForUpdate) + "'";
            else
                sql = "UPDATE FTR.MASTERSUBBIE SET MAPPINGID=" + Convert.ToString(mappingID) + " WHERE VENDORCODE='" + Convert.ToString(partyCodeForUpdate) + "'";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
         
            return j;
        }

        public DataSet FetchPartiesWithOutMapping(int vendorTypeID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql1 = "SELECT U.PARTYCODE,C.CREDNAME PARTYNAME FROM FTR.UNKNOWNPARTIES U  INNER JOIN CREDITORS C ON C.CREDNUMBER = U.PARTYCODE WHERE VEDORTYPEID = 1  ORDER BY PARTYCODE ";
            string sql2 = "SELECT U.PARTYCODE,S.SUBNAME PARTYNAME FROM FTR.UNKNOWNPARTIES U   INNER JOIN SUBCONTRACTORS S ON S.SUBNUMBER = U.PARTYCODE WHERE VEDORTYPEID = 2  ORDER BY PARTYCODE ";
       
            string sql;
            if (vendorTypeID == 1)
                sql = sql1;
            else
                sql = sql2;

            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public DataSet FetchPartiesWithMapping(int vendorTypeID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql1 = "SELECT MC.VENDORCODE PARTYCODE,UPPER(C.CREDNAME) PARTYNAME,M.MAJORCATEGORY,M.MINORCATEGORY,M.CATEGORY   ";
            sql1 = sql1 + "FROM FTR.MASTERCREDITOR MC INNER JOIN  CREDITORS C ON MC.VENDORCODE = C.CREDNUMBER   ";
            sql1 = sql1 + "INNER JOIN  FTR.MAPPINGMASTER M ON MC.MAPPINGID = M.MAPPINGID  ORDER BY PARTYNAME,MAJORCATEGORY,MINORCATEGORY,CATEGORY";
            string sql2 = "SELECT MC.VENDORCODE PARTYCODE,UPPER(S.SUBNAME) PARTYNAME,M.MAJORCATEGORY,M.MINORCATEGORY,M.CATEGORY    ";
            sql2 = sql2 + "FROM FTR.MASTERSUBBIE MC INNER JOIN  SUBCONTRACTORS S ON MC.VENDORCODE = S.SUBNUMBER ";
            sql2 = sql2 + "INNER JOIN  FTR.MAPPINGMASTER M ON MC.MAPPINGID = M.MAPPINGID  WHERE SUBNAME<>'' ORDER BY PARTYNAME,MAJORCATEGORY,MINORCATEGORY,CATEGORY";

            string sql;
            if (vendorTypeID == 1)
                sql = sql1;
            else
                sql = sql2;

            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int DeleteExistingEntries(int ftrID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM FTR.FTRAMOUNTAPPROVED WHERE FTRID=" + Convert.ToString(ftrID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public int UpdateCustodian(int ftrID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Update FTR.FTRHEADER SET CUSTODIAN=CUSTODIAN+1 WHERE FTRID="+ Convert.ToString(ftrID);
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            sql = "Update FTR.FTRHEADER SET FTRSTATUS=1 WHERE CUSTODIAN>=5 ";
            int J = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }

        public int UpdateFTRLog(int ftrID,string loginID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            DateTime now = DateTime.Now;
            string sql = "INSERT INTO FTR.FTRLOG(FTRID,LOGINID,ACTIONDATE) VALUES(";
            sql = sql + Convert.ToString(ftrID) + ",'" + Convert.ToString(loginID) + "','" + now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "')";
            int J = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return J;
        }
        #endregion
        #region GSTCredit


        public int DeleteExistingGSTCredits()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "DELETE FROM FTR.GSTCREDIT";
            int j = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return j;
        }


        public DataSet GSTCredit()
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "SELECT 'Creditor' VENDORTYPE, GC.PARTYCODE PARTYCODE, UPPER(C.CREDNAME) PARTYNAME , GC.GSTCREDIT ";
            sql = sql + "  FROM FTR.GSTCREDIT GC INNER JOIN CREDITORS C ON GC.PARTYCODE = C.CREDNUMBER WHERE GSTCREDIT<>0  ";
            sql = sql + "  UNION  ";
            sql = sql + " SELECT 'SubCon'   VENDORTYPE, GC.PARTYCODE PARTYCODE, UPPER(S.SUBNAME) PARTYNAME , GC.GSTCREDIT  ";
            sql = sql + "  FROM FTR.GSTCREDIT GC INNER JOIN SUBCONTRACTORS S ON GC.PARTYCODE = S.SUBNUMBER WHERE GSTCREDIT<>0 ";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds;
        }

        public int CheckAlreadyHaveGSTEntry(string partyCode)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql = "Select * FROM FTR.GSTCREDIT WHERE PARTYCODE='" + Convert.ToString(partyCode) + "'";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            int row = Convert.ToInt16(ds.Tables[0].Rows.Count);
            if (row > 0)
                return 1;
            else
                return 0;
        }

        public int AddGSTEntry(string partyCode,decimal  amount, int route)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            string sql1 = "INSERT INTO FTR.GSTCREDIT(PARTYCODE,GSTCREDIT) VALUES ('" + Convert.ToString(partyCode) + "'," + Convert.ToString(amount) + ")";
            string sql2 = "UPDATE FTR.GSTCREDIT SET GSTCREDIT=" + Convert.ToString(amount) + "  WHERE PARTYCODE='" + Convert.ToString(partyCode) + "'";
            string sql;
            if (route == 0)
                sql = sql1;
            else
                sql = sql2;
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.Text, sql);
            return i;
        }
        #endregion
    }
}
   





