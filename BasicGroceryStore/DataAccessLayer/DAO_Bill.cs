using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class DAO_Bill
    {
        // Imported or Ordered

        public static bool createBill(Bills bill, string typeBill, string customerName)
        {
            if (customerName == null)
                return true;
            return false;
        }

        public static bool updateBill(Bills bill, string typeBill, string customerName)
        {
            if (customerName == null)
                return true;
            return false;
        }

        public static bool deleteBill(string typeBill, string id)
        {
            return false;
        }

        public DataTable getAllBill(string typeBill)
        {
            return DAO.Instance.ExecuteQuery($"select * from {typeBill}", CommandType.Text, null);
        }

        public static int getQuantityOfBill(string typeBill)
        {
            return 0;
        }

        public static int getTotalValueOfBill(string typeBill)
        {
            return 0;
        }

        public DataTable FindBillByDateRange(string typeBill, DateTime from, DateTime to)
        {
            return null;
        }
    }
}
