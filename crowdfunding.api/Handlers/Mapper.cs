using crowdfunding.api.Models;
using crowdfunding.bll.Entities;

namespace crowdfunding.api.Handlers
{
    public static class Mapper
    {
        public static Project ToProject(this ProjectInsert entity)
        {
            if (entity == null) return null;
            return new Project()
            {
                Name = entity.Name,
                Created = entity.Created,
                Modified = entity.Modified,
            };
        }
        public static Project ToProject(this ProjectUpdate entity)
        {
            if (entity == null) return null;
            return new Project()
            {
                Name = entity.Name,
                Created = entity.Created,
                Modified = entity.Modified,
            };
        }
    }
}
