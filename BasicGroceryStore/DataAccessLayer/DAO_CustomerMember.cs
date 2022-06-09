using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class DAO_CustomerMember
    {
        public static bool createCustomerMember(CustomerMember cus)
        {
            return false;
        }

        public static bool updateCustomerMember(CustomerMember cus)
        {
            return false;
        }

        public static bool deleteCustomerMember(string name)
        {
            return false;
        }

        public static DataTable getAllCustomerMember()
        {
            return DAO.Instance.ExecuteQuery("select * from CustomerMember order by Value DESC", CommandType.Text, null);
        }
    }
}
