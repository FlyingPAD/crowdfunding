using crowdfunding.cmn.Services;
using crowdfunding.dal.Entities;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Tools.Connections;
using static crowdfunding.dal.Mapper.Mapper;

namespace crowdfunding.dal.Services
{
    public class UserService : BaseService, IUserRepository<User>
    {
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="config"></param>
        public UserService(IConfiguration config) : base(config) { }
        // -------------------------------------------------------------------------        
        /// <summary>
        /// METHOD : LOGIN
        /// </summary>
        /// <returns>Type : Object : User</returns>
        public User? Login(string email, string password)
        {
            Connection con = new Connection(InvariantName, ConnectionString);
            Command com = new Command("SP_User_Login", true);
            com.AddParameter("Email", email);
            com.AddParameter("Password", password);
            return con.ExecuteReader(com, ConvertUser).ToList().SingleOrDefault();
        }
        // -------------------------------------------------------------------------
        /// <summary>
        /// METHOD : REGISTER
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Type : Object : User</returns>      
        public User? Register(User data)
        {
            Connection con = new Connection(InvariantName, ConnectionString);
            Command com = new Command("SP_User_Register", true);
            com.AddParameter("FirstName", data.FirstName);
            com.AddParameter("LastName", data.LastName);
            com.AddParameter("Email", data.Email);
            com.AddParameter("Password", data.Password);
            return con.ExecuteReader(com, ConvertUser).ToList().SingleOrDefault();
        }
    }
}