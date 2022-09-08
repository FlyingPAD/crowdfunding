using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace crowdfunding.dal.Services
{
    public abstract class BaseService
    {
        private readonly IConfiguration _config;
        protected BaseService(IConfiguration config)
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            _config = config;
        }
        protected string ConnectionString
        {
            get
            {
                return this._config.GetConnectionString("localDb");
            }
        }
        protected string InvariantName
        {
            get
            {
                return this._config.GetSection("InvariantNames").GetSection("localDb").Value;
            }
        }
    }
}