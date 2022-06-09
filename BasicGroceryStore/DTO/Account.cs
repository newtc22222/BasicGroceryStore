using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class Account
    {
        private string staff_id;
        private string username;
        private string password;

        public string Staff_id { get => staff_id; set => staff_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Account(string staff_id, string username, string password)
        {
            this.staff_id = staff_id;
            this.username = username;
            this.password = password;
        }
    }
}
