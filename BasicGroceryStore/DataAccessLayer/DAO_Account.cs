using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Account
    {
        public static bool createAccount(Account acc)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_InsertAccount", CommandType.StoredProcedure, 
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public static bool updateAccount(Account acc)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_UpdateAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public static bool deleteAccount(Account acc)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_DeleteAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id)) > 0) ? true : false;
        }

        public static void SaveAccount(Account acc, bool isSave)
        {
            DAO_Information dao = new DAO_Information("Account.xml");
            dao.updateSaveAccount(acc, isSave);
        }

        public static string checkLogin(string username, string password)
        {
            object staff_id = DAO.Instance.ExecuteScalar($"select dbo.func_CheckLogin('{username}', '{password}')", CommandType.Text);
            return staff_id.ToString();
        }
    }
}
