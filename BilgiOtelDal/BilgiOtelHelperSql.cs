using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDal
{
    public static class BilgiOtelHelperSql
    {

        //sqlcommand 
        private static SqlConnection myconnection()
        {
            return new SqlConnection( dataConnections.get_MsSqlConnectionString);
        }

            
        public static SqlCommand mysqlcommad(string mysqlscript, string mycommandtype, SqlParameter[] myParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = mysqlscript;
            cmd.Connection = myconnection();

            if (mycommandtype == "sp")
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            if (myParameters != null)
            {
                cmd.Parameters.AddRange(myParameters);
            }
            return cmd;
        }

        //execute metotlar
        public static int myExecuteNonquery(string spname, SqlParameter[] cmdparams, string mycommadntype)
        {
            SqlCommand cmd = mysqlcommad(spname, mycommadntype, cmdparams);
            cmd.Connection.Open();
            int donensatir = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return donensatir;
        }
        public static object myExecuteScalar(string spname, SqlParameter[] cmdparams, string mycommadntype)
        {
            SqlCommand cmd = mysqlcommad(spname, mycommadntype, cmdparams);
            cmd.Connection.Open();
            object donensatir = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return donensatir;
        }
        public static SqlDataReader myExecuteReader(string spname, SqlParameter[] cmdparams, string mycommadntype)
        {
            SqlCommand cmd = mysqlcommad(spname, mycommadntype, cmdparams);
            cmd.Connection.Open();
            SqlDataReader donensatir = cmd.ExecuteReader();
           //cmd.Connection.Close();
            return donensatir;
        }
    }
}
