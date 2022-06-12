using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_CustomerMember
    {
        public static bool createCustomerMember(CustomerMember cus)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_InsertCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", cus.Name),
                new SqlParameter("@Phone", cus.Phone),
                new SqlParameter("@DateJoin", cus.DateJoin),
                new SqlParameter("@Value", cus.Value),
                new SqlParameter("@Level", cus.E_level)) > 0) ? true : false;
        }

        public static bool updateCustomerMember(CustomerMember cus)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_UpdateCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", cus.Name),
                new SqlParameter("@Phone", cus.Phone),
                new SqlParameter("@DateJoin", cus.DateJoin),
                new SqlParameter("@Value", cus.Value),
                new SqlParameter("@Level", cus.E_level)) > 0) ? true : false;
        }

        public static bool deleteCustomerMember(string name)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_DeleteCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", name)) > 0) ? true : false;
        }

        public static DataTable getAllCustomerMember()
        {
            return DAO.Instance.ExecuteQuery("select * from CustomerMember order by Value DESC", CommandType.Text, null);
        }
    }
}
