using System.Data;

namespace BasicGroceryStore
{
    public interface ICustomerServices
    {
        /// <summary>
        /// Get all data of Customer in DBMS
        /// </summary>
        /// <returns></returns>
        DataTable GetAllCustomer();
    }
}
