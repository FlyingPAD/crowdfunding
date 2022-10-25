using crowdfunding.cmn.Services;
using crowdfunding.dal.Entities;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Tools.Connections;
using static crowdfunding.dal.Mapper.Mapper;

namespace crowdfunding.dal.Services
{
    public class ProjectService : BaseService, IProjectRepository<int, Project>
    {
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="config"></param>
        public ProjectService(IConfiguration config) : base(config) { }
        // -------------------------------------------------------------------------        
        /// <summary>
        /// METHOD : GET ALL PROJECTS
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Project> Get()
        {
            Connection con = new Connection(InvariantName, ConnectionString);
            Command com = new Command("SP_Project_Get", true);
            return con.ExecuteReader<Project>(com, ConvertProject);
        }
        // -------------------------------------------------------------------------  
        /// <summary>
        /// METHOD : GET PROJECT BY ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Project Get(int id)
        {
            Connection con = new Connection(InvariantName, ConnectionString);
            Command com = new Command("SP_Project_Get_By_Id", true);
            com.AddParameter("Id", id);
            return con.ExecuteReader<Project>(com, ConvertProject).SingleOrDefault();
        }
    }
}