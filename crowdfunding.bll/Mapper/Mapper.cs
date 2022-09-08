using B = crowdfunding.bll.Entities;
using D = crowdfunding.dal.Entities;

namespace crowdfunding.bll.Mapper
{
    public static class Mapper
    {
        public static B.Project ToBLL(this D.Project entity)
        {
            if (entity == null) return null;
            return new B.Project()
            {
                Id = entity.Id,
                Name = entity.Name,
                Created = entity.Created,
                Modified = entity.Modified,
            };
        }
        public static D.Project ToDAL(this B.Project entity)
        {
            if (entity == null) return null;
            return new D.Project()
            {
                Id = entity.Id,
                Name = entity.Name,
                Created = entity.Created,
                Modified = entity.Modified,
            };
        }
    }
}