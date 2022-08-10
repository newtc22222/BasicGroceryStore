using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal static class Config
    {
        private static string serverName = "DESKTOP-LI9ERHL";
        private static string databaseName = "GroceryStore";
        private static string username = "sa";
        private static string password = "123456";

        public static void setUsername(string Username)
        {
            username = Username;
        }

        public static void setPassword(string Password) 
        {
            password = Password;
        }

        public static string getSQLConnectionString()
        {
            return $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        }

        public static string getSQLConnectionStringWithUser()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString["Server"] = serverName;
            connectionString["Database"] = databaseName;
            connectionString["User ID"] = username;
            connectionString["Password"] = password;
            return connectionString.ToString();
            //return $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
        }
    }
}
