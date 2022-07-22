using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    public interface IAccountServices
    {
        /// <summary>
        /// Checking user login in the system
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>staff's id (if staff login)</returns>
        string CheckLogin(string username, string password);

        /// <summary>
        /// Get account of staff after him/her login
        /// </summary>
        /// <param name="staff_id"></param>
        /// <returns></returns>
        Account GetAccountByStaffID(string staff_id);

        /// <summary>
        /// Save data to Account.xml to next login (if checked remember)
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="isSave"></param>
        void SaveAccount(Account acc, bool isSave);
    }
}
