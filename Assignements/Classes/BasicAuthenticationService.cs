using Assignements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Classes
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private string StoredUserName = "Youssef";
        private string StoredPassword = "1234567";
        private string StoredRole = "Admin";
        
        public bool AuthenticateUser(string UserName, string Password)
        {
            return UserName == StoredUserName && Password == StoredPassword;
        }

        
        public bool AuthorizeUser(string UserName, string role)
        {
           return UserName == StoredUserName && role == StoredRole;
        }
    }
}
