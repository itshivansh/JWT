using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public class AuthRepository : IAuthRepository
    {
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool IsUserExists(string userId)
        {
            throw new NotImplementedException();
        }

        public bool LoginUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
