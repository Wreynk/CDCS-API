#region

using System;
using System.Linq;
using System.Linq.Expressions;
using TLT.BaseModel.Interfaces;

#endregion

namespace CDCS.Data.Repository.Base {

    public interface IAppRepository<TEntity> : IDisposable where TEntity : IBaseEntity {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        TEntity             GetById(int id);
        void                Add(TEntity obj);
        void                InsertOrUpdate(TEntity entity);
        void                InsertOnly(TEntity entity);
        void                Update(TEntity obj);
        void                Remove(int id);
        void                Delete(int id);
        int                 SaveChanges();
    }

}