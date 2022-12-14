using crowdfunding.bll.Entities;
using crowdfunding.bll.Mapper;
using crowdfunding.cmn.Services;
using System.Collections.Generic;
using System.Linq;
using D = crowdfunding.dal.Entities;

namespace crowdfunding.bll.Services
{
    public class ProjectService : IProjectRepository<int, Project>
    {
        /// <summary>
        /// PROPERTIES
        /// </summary>
        private readonly IProjectRepository<int, D.Project> _repository;
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="repository"></param>
        public ProjectService(IProjectRepository<int, D.Project> repository)
        {
            this._repository = repository;
        }
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// METHOD : GET ALL PROJECTS
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Project> Get()
        {
            return _repository.Get().Select(c => c.ToBLL());
        }
        // ------------------------------------------------------------------------------------------------------
        /// <summary>
        /// METHOD : GET PROJECT BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Project Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }
    }
}