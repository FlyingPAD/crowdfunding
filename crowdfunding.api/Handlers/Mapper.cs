using crowdfunding.api.Models;
using crowdfunding.bll.Entities;

namespace crowdfunding.api.Handlers
{
    public static class Mapper
    {
        /* ------------------------------------------------------------------------------------ */
        /* - USERS */
        /* ------------------------------------------------------------------------------------ */
        public static User ToUser(this UserRegister entity)
        {
            if (entity == null) return null;
            return new User()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Password = entity.Password,
            };
        }
        public static User ToUser(this UserLogin entity)
        {
            if (entity == null) return null;
            return new User()
            {
                Email = entity.Email,
                Password = entity.Password
            };
        }
    }
}