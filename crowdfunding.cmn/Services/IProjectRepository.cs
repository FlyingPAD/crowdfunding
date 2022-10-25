using System.Collections.Generic;
using System.Security.Cryptography;

namespace crowdfunding.cmn.Services
{
    public interface IProjectRepository<TId, TProject> where TProject : class
    {
        IEnumerable<TProject> Get();
        TProject Get(TId id);
    }
}