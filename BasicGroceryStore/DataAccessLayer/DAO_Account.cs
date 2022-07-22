using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Account : IControl<Account>, IAccountServices
    {
        public bool Create(Account acc)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_InsertAccount", CommandType.StoredProcedure, 
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public bool Update(Account acc)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_UpdateAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public bool Delete(Account acc)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_DeleteAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id)) > 0) ? true : false;
        }

        public string CheckLogin(string username, string password)
        {
            object staff_id = DataProvider.Instance.ExecuteScalar($"select dbo.func_CheckLogin('{username}', '{password}')", CommandType.Text);
            return staff_id.ToString();
        }

        public Account GetAccountByStaffID(string staff_id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from Account where StaffID = {staff_id}", CommandType.Text, null);
            return new Account(staff_id, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
        }

        public void SaveAccount(Account acc, bool isSave)
        {
            DAO_Information dao = new DAO_Information("Account.xml");
            dao.UpdateSaveAccount(acc, isSave);
        }        
    }
}
