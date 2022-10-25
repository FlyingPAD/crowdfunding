using crowdfunding.bll.Entities;
using crowdfunding.bll.Mapper;
using crowdfunding.cmn.Services;
using System.Collections.Generic;
using System.Linq;
using D = crowdfunding.dal.Entities;

namespace crowdfunding.bll.Services
{
    public class UserService : IUserRepository<User>
    {
        /// <summary>
        /// PROPERTIES :
        /// </summary>
        private readonly IUserRepository<D.User> _repository;
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// CONSTRUCTOR :
        /// </summary>
        /// <param name="repository"></param>
        public UserService(IUserRepository<D.User> repository)
        {
            this._repository = repository;
        }
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// METHOD : LOGIN
        /// </summary>
        /// <returns></returns>
        public User? Login(string email, string password)
        {
            return _repository.Login(email, password)?.ToBLL();
        }
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// METHOD : REGISTER
        /// </summary>
        /// <returns></returns>
        public User? Register(User user)
        {
            return _repository.Register(user.ToDAL())?.ToBLL();
        }
    }
}