namespace BasicGroceryStore
{
    internal class Config
    {
        private static string databaseName = @"PHIVO_Z1704\PHIVO";
        private static string userName = "";
        private static string passWord = "";

        public static string getSQLConnectionString()
        {
            return $"Data Source={databaseName};Initial Catalog=GroceryStore;Integrated Security=True";
            //return @"Data Source=PHIVO_Z1704\PHIVO;Initial Catalog=GroceryStore;Integrated Security=True";
        }

        public static string getSQLConnectionStringWithUser()
        {
            return $"Data Source={databaseName};Initial Catalog={userName};User ID=sa;Password={passWord}";
        }
    }
}
