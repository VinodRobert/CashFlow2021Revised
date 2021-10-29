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
        #region

    }
}
