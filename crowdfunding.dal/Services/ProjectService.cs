using crowdfunding.cmn.Services;
using crowdfunding.dal.Entities;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Tools.Connections;
using static crowdfunding.dal.Mapper.Mapper;

namespace crowdfunding.dal.Services
{
    public class ProjectService : BaseService, IProjectRepository<Project>
    {
            public ProjectService(IConfiguration config) : base(config) { }
        // -----------------------------------------------------------------------------------------------------------------
        // - CREATE
        // -----------------------------------------------------------------------------------------------------------------
            public int Insert(Project data)
            {
                Connection con = new Connection(InvariantName, ConnectionString);
                Command com = new Command("CreateGlossary", true);
                com.AddParameter("Name", data.Name);
                com.AddParameter("Created", data.Created);
                com.AddParameter("Modified", data.Modified);
                return (int)con.ExecuteScalar(com);
            }
        // -----------------------------------------------------------------------------------------------------------------
        // - READ
        // -----------------------------------------------------------------------------------------------------------------
            public IEnumerable<Project> Get()
            {
                Connection con = new Connection(InvariantName, ConnectionString);
                Command com = new Command("SELECT * FROM Project");
                return con.ExecuteReader<Project>(com, ConvertProject);
            }
            public Project Get(int id)
            {
                Connection con = new Connection(InvariantName, ConnectionString);
                Command com = new Command("SELECT * FROM Project WHERE Id = @id");
                com.AddParameter("Id", id);
                return con.ExecuteReader<Project>(com, ConvertProject).SingleOrDefault();
            }
        // -----------------------------------------------------------------------------------------------------------------
        // - UPDATE
        // -----------------------------------------------------------------------------------------------------------------
            public bool Update(int id, Project data)
            {
                Connection con = new Connection(InvariantName, ConnectionString);
                Command com = new Command("UpdateProject", true);
                com.AddParameter("Id", id);
                com.AddParameter("Name", data.Name);
                com.AddParameter("Created", data.Created);
                com.AddParameter("Modified", data.Modified);
                return con.ExecuteNonQuery(com) > 0;
            }
        // -----------------------------------------------------------------------------------------------------------------
        // - DELETE
        // -----------------------------------------------------------------------------------------------------------------
            public bool Delete(int id)
            {
                Connection con = new Connection(InvariantName, ConnectionString);
                Command com = new Command("DeleteProject", true);
                com.AddParameter("Id", id);
                return con.ExecuteNonQuery(com) > 0;
            }
    }
}