using System;

namespace BasicGroceryStore
{
    internal class BUS_Account : IControl<Account>, IAccountServices
    {
        private DAO_Account dao;

        public BUS_Account()
        {
            dao = new DAO_Account();
        }

        public bool Create(Account acc)
        {
            return dao.Create(acc);
        }

        public bool Update(Account acc)
        {
            return dao.Update(acc);
        }

        public bool Delete(Account acc)
        {
            return dao.Delete(acc);
        }

        public string CheckLogin(string username, string password)
        {
            return dao.CheckLogin(username, password);
        }

        public Account GetAccountByStaffID(string staff_id)
        {
            return dao.GetAccountByStaffID(staff_id);
        }

        public void SaveAccount(Account acc, bool isSave)
        {
            try
            {
                dao.SaveAccount(acc, isSave);
            }
            catch (Exception)
            {
                throw new Exception("Can not save account!");
            }                
        }
        
    }
}
