#region

using System;
using System.Linq;

#endregion

namespace CDCS.Data.Services.Base
{

    public interface IAppService<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        void Delete(int id);
        int SaveChanges();
    }

}