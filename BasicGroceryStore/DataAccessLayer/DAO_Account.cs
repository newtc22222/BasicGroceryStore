using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Account
    {
        public static bool createAccount(Account acc)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_InsertAccount", CommandType.StoredProcedure, 
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public static bool updateAccount(Account acc)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_UpdateAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id),
                new SqlParameter("@Username", acc.Username),
                new SqlParameter("@Password", acc.Password)) > 0) ? true : false;
        }

        public static bool deleteAccount(Account acc)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_DeleteAccount", CommandType.StoredProcedure,
                new SqlParameter("@StaffID", acc.Staff_id)) > 0) ? true : false;
        }

        public static string checkLogin(string username, string password)
        {
            return (string)DAO.Instance.ExecuteScalar($"select func_CheckLogin('{username}', '{password}')", CommandType.Text);
        }
    }
}
