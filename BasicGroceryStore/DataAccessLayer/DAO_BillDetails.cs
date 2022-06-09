using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class DAO_BillDetails
    {
        public static bool createBillDetail(BillsDetail item, string typeBill)
        {
            return false;
        }

        public static bool updateBillDetail(BillsDetail item, string typeBill)
        {
            return false;
        }

        public static bool deleteBillDetail(BillsDetail item, string typeBill)
        {
            return false;
        }

        public DataTable getAllItem_BillDetail(string typeBill, string id)
        {
            return DAO.Instance.ExecuteQuery($"select * from {typeBill}Details where Id={id}", CommandType.Text, null);
        }
    }
}
