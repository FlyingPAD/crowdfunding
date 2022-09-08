using crowdfunding.bll.Entities;
using crowdfunding.bll.Mapper;
using crowdfunding.cmn.Services;
using System.Collections.Generic;
using System.Linq;
using D = crowdfunding.dal.Entities;

namespace crowdfunding.bll.Services
{
    public class ProjectService : IProjectRepository<Project>
    {
        // ------------------------------------------------------------------------------------------------------
        // - PROPERTIES
        // ------------------------------------------------------------------------------------------------------
            private readonly IProjectRepository<D.Project> _repository;
        // ------------------------------------------------------------------------------------------------------
        // - CONSTRUCTOR
        // ------------------------------------------------------------------------------------------------------
            public ProjectService(IProjectRepository<D.Project> repository)
            {
                this._repository = repository;
            }
        // ------------------------------------------------------------------------------------------------------
        // - METHODS
        // ------------------------------------------------------------------------------------------------------
            public int Insert(Project data)
            {
                return _repository.Insert(data.ToDAL());
            }
            public IEnumerable<Project> Get()
            {
                return _repository.Get().Select(c => c.ToBLL());
            }
            public Project Get(int id)
            {
                return _repository.Get(id).ToBLL();
            }
            public bool Update(int id, Project data)
            {
                return _repository.Update(id, data.ToDAL());
            }
            public bool Delete(int id)
            {
                return _repository.Delete(id);
            }
    }
}