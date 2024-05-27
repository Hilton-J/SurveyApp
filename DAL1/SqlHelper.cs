using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL1
{
    public class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["dbSurvey"].ConnectionString;

        #region Select()
        internal static DataTable Select(string commandName, CommandType cmdType)
        {
            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;

                    try
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            da.Fill(dt);
                        }
                    }
                    catch (SqlException)
                    {
                        throw new System.Exception("Not available at this time");
                    }

                }
            }
            return dt;
        }
        #endregion Select()
        #region NonQuery()
        internal static bool NonQuery(string commandName, CommandType cmbType, SqlParameter[] pars)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmbType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(pars);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            return result > 0;
        }
        #endregion NonQuery()
    }
}
