using System.Collections.Generic;

namespace crowdfunding.cmn.Services
{
    public interface IRepository <TId, TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
        TId Insert(TEntity newData);
        bool Update(TId id,TEntity newData);
        bool Delete(TId id);
    }
}