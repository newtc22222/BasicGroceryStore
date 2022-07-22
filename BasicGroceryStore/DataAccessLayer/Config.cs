namespace BasicGroceryStore
{
    internal static class Config
    {
        private static string serverName = @"PHIVO_Z1704\PHIVO";
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
            return $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
        }
    }
}
