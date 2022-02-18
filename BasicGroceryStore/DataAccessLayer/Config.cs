using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class Config
    {
        private static string databaseName = "PhiVo-Z1704";
        private static string userName = "";
        private static string passWord = "";

        public static string getSQLConnectionString()
        {
            return $"Data Source={databaseName};Initial Catalog=GroceryStore;Integrated Security=True";
        }

        public static string getSQLConnectionStringWithUser()
        {
            return $"Data Source={databaseName};Initial Catalog={userName};User ID=sa;Password={passWord}";
        }
    }
}
