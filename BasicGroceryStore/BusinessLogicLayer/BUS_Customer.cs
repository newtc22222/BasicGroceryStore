using System.Data;

namespace BasicGroceryStore
{
    internal class BUS_Customer : IControl<Customer>, ICustomerServices
    {
        private DAO_Customer dao;

        public BUS_Customer()
        {
            dao = new DAO_Customer();
        }

        public bool Create(Customer customer)
        {
            return dao.Create(customer);
        }

        public bool Update(Customer customer)
        {
            return dao.Update(customer);
        }

        public bool Delete(Customer customer)
        {
            return dao.Delete(customer);
        }

        public DataTable GetAllCustomer()
        {
            return dao.GetAllCustomer();
        }
    }
}
