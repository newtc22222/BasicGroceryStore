using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    public class DataProvider
    {
        private string connectionString = Config.getSQLConnectionString();
        private SqlConnection connection;
        private SqlCommand cmd;
        
        /// <summary>
        /// Singleton DataProvider
        /// </summary>
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();  
                }
                return instance;
            }
        }

        public DataProvider()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            cmd = connection.CreateCommand();
        }

        /// <summary>
        /// Query for INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="sqlExpess"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <returns>Number of rows</returns>
        public int ExecuteNonQuery(string sqlExpess, CommandType type, params SqlParameter[] param)
        {
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            cmd.Parameters.Clear();
            foreach (SqlParameter a in param)
            {
                cmd.Parameters.Add(a);
            }
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        /// <summary>
        /// Query for SELECT
        /// </summary>
        /// <param name="sqlExpess"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <returns>DataTable for List Object</returns>
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

        /// <summary>
        /// Query for value (using function in sql)
        /// </summary>
        /// <param name="sqlExpess"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <returns>Number or String of Object (may be null)</returns>
        public object ExecuteScalar(string sqlExpess, CommandType type, params SqlParameter[] param)
        {
            cmd.CommandType = type;
            cmd.CommandText = sqlExpess;
            
            if (param != null)
            {
                foreach (SqlParameter p in param)
                    cmd.Parameters.Add(p);
            }

            try
            {
                return cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}
