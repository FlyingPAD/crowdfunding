using B = crowdfunding.bll.Entities;
using D = crowdfunding.dal.Entities;

namespace crowdfunding.bll.Mapper
{
    public static class Mapper
    {
        /* ------------------------------------------------------------------------------------ */
        /* - PROJECT */
        /* ------------------------------------------------------------------------------------ */
            public static B.Project ToBLL(this D.Project entity)
            {
                if (entity == null) return null;
                return new B.Project()
                {
                    Id = entity.Id,
                    Created = entity.Created,
                    Modified = entity.Modified,
                    Name = entity.Name,
                    Description = entity.Description,
                    UrlVideo = entity.UrlVideo,
                    UrlPicture = entity.UrlPicture,
                    Money_Ceiling = entity.Money_Ceiling,
                    UserId = entity.UserId,
                };
            }
            public static D.Project ToDAL(this B.Project entity)
            {
                if (entity == null) return null;
                return new D.Project()
                {
                    Id = entity.Id,
                    Created = entity.Created,
                    Modified = entity.Modified,
                    Name = entity.Name,
                    Description = entity.Description,
                    UrlVideo = entity.UrlVideo,
                    UrlPicture = entity.UrlPicture,
                    Money_Ceiling = entity.Money_Ceiling,
                    UserId = entity.UserId,
                };
            }
        /* ------------------------------------------------------------------------------------ */
        /* - USER */
        /* ------------------------------------------------------------------------------------ */
            public static B.User ToBLL(this D.User entity)
            {
                return new B.User()
                {
                    Id = entity.Id,
                    Created = entity.Created,
                    Modified = entity.Modified,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                    Password = entity.Password,
                    User_Category = entity.User_Category,
                };
            }
            public static D.User ToDAL(this B.User entity)
            {
                if (entity == null) return null;
                return new D.User()
                {
                    Id = entity.Id,
                    Created = entity.Created,
                    Modified = entity.Modified,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                    Password = entity.Password,
                    User_Category = entity.User_Category,
                };
            }
    }
}