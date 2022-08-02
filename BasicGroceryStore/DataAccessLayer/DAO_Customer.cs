using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Customer : IControl<Customer>, ICustomerServices
    {
        public bool Create(Customer customer)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_InsertCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@DateJoin", customer.DateJoin),
                new SqlParameter("@Value", customer.Value),
                new SqlParameter("@Level", customer.E_level)) > 0) ? true : false;
        }

        public bool Update(Customer customer)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_UpdateCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@DateJoin", customer.DateJoin),
                new SqlParameter("@Value", customer.Value),
                new SqlParameter("@Level", customer.E_level)) > 0) ? true : false;
        }

        public bool Delete(Customer customer)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_DeleteCustomerMember", CommandType.StoredProcedure,
                new SqlParameter("@Name", customer.Name)) > 0) ? true : false;
        }

        public DataTable GetAllCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("select * from CustomerMember order by Value DESC", CommandType.Text, null);
        }
    }
}
