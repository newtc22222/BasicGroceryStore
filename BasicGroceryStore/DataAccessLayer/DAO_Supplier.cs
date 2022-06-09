using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class DAO_Supplier
    {
        public static bool createSupplier(Supplier supplier)
        {
            return false;
        }

        public static bool updateSupplier(Supplier supplier)
        {
            return false;
        }

        public static bool deleteSupplier(string id)
        {
            return false;
        }

        public static DataTable getAllSupplier()
        {
            return DAO.Instance.ExecuteQuery("select * from Supplier", CommandType.Text, null);
        }

        public static DataTable FindSupplierByAddress(string address)
        {
            return null;
        }

        public static DataTable FindSupplierByName(string namme)
        {
            return null;
        }

        public static DataTable FindSupplierByTypeProduct(string typeProduct)
        {
            return null;
        }
    }
}
