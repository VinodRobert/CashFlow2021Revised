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

        #region FTR List

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
            string sql = "SELECT H.FTRID,B.BORGNAME,H.FTRNUMBER,H.CREATEDATE,H.LASTUPDATE,CASE  WHEN H.FTRSTATUS = 0  THEN 'Open'  WHEN H.FTRSTATUS = 1  THEN 'Closed'";
            sql = sql + " END AS FTRSTATUS, CASE WHEN H.CUSTODIAN=1 THEN 'Project Site'  WHEN H.CUSTODIAN=2 THEN 'Site Accountant'  WHEN H.CUSTODIAN=3  THEN 'Accounts Head' ";
            sql = sql + " WHEN H.CUSTODIAN=4 THEN 'Control Cell'  WHEN H.CUSTODIAN = 5 THEN 'Final Approver'  END AS CUSTODIAN ,";
            sql = sql + "'Open' as FOREDIT, 'Excel' as FOREXPORT FROM FTR.FTRHEADER H INNER JOIN BORGS B ON H.BORGID = B.BORGID ";
            sql = sql + " WHERE H.BORGID IN (SELECT BSBORGID FROM FTR.PROJECTS WHERE PROJECTID IN (SELECT PROJECTID  FROM FTR.USERPROJECTS WHERE USERID IN ";
            sql = sql + " (SELECT USERID FROM FTR.FTRUSERS WHERE BSLOGINID= '" + Convert.ToString(loginID) + "'))) ORDER BY FTRSTATUS DESC,BORGNAME";
            DataSet ds = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return ds; 
        }


        public int GenerateFTRHeader(int borgID)
        {
            string _connectionString = SqlHelper.GetConnectionString();
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@BORGID", SqlDbType.Int);
            arParms[0].Value = borgID;
            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "FTR.spCreateFTRHeader", arParms);
            return i;
        }

        public DataSet GenerateFTR(int borgID,int headerAlso)
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
    }
}
