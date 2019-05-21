using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    class User
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userType { get; set; }

        public User(int Id, string FullName, string UserName, string Password, int UserType)
        {
            id = Id;
            fullName = FullName;
            userName = UserName;
            password = Password;
            userType = UserType;
        }

        public User()
        {

        }
    }
}
