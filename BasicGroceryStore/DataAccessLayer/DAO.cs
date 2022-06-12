using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    public class DAO
    {
        private string connectionString = Config.getSQLConnectionString();
        private static SqlConnection connection;
        private static SqlCommand cmd;

        private static DAO instance;
        public static DAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DAO();  
                }
                return instance;
            }
        }

        public DAO()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            cmd = connection.CreateCommand();
        }

        public int ExecuteNonQuery(string sqlExpess, CommandType type, params SqlParameter[] param)
        {
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in param)
            {
                cmd.Parameters.Add(a);
            }
            return cmd.ExecuteNonQuery();
        }

        public DataTable ExecuteQuery(string sqlExpess, CommandType type, params SqlParameter[] param)
        {
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
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

        public object ExecuteScalar(string sql, CommandType type, params SqlParameter[] param)
        {
            object result;
            cmd.CommandType = type;
            cmd.CommandText = sql;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                    cmd.Parameters.Add(p);
            }
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                return null;
            }
            return result;
        }
    }
}
