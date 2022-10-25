using System.Collections.Generic;
using System.Security.Cryptography;

namespace crowdfunding.cmn.Services
{
    public interface IUserRepository<TUser> where TUser : class
    {
        TUser? Login(string email, string password);
        TUser? Register(TUser user);
    }
}