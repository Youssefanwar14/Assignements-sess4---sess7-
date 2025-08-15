using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Interfaces
{
    public interface IAuthenticationService
    {
        public bool AuthenticateUser(string UserName,string Password);
        public bool AuthorizeUser(String UserName,String role);

    }
}
