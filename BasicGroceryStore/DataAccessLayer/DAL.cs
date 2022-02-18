using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    public class DAL
    {
        private string connectionString = Config.getSQLConnectionString();
        private static SqlConnection connection;
        private static SqlCommand cmd;

        public DAL()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                cmd = connection.CreateCommand();
            }
            catch (SqlException)
            {

            }
        }

        public static void ExcuteNonQuery(string sqlExpess, CommandType type, params SqlParameter[] param)
        {
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in param)
            {
                cmd.Parameters.Add(a);
            }
            cmd.ExecuteNonQuery();
        }

        public static DataTable ExecuteQuery(string strSql, CommandType ct, params SqlParameter[] param)
        {
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            if (param != null)
            {
                foreach (SqlParameter p in param)
                    cmd.Parameters.Add(p);
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static object ExecuteScalar(string sql, CommandType type)
        {
            object result;
            cmd.CommandType = type;
            cmd.CommandText = sql;
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
    }
}
