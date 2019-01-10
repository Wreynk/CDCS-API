#region

using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TLT.BaseModel.Interfaces;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Data.Repository.Base
{

    public class AppRepository<TEntity> : IAppRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly CdcsContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public AppRepository(CdcsContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;
            foreach (var includeProperty in includeProperties) query = query.Include(includeProperty);
            return query;
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public virtual void InsertOrUpdate(TEntity entity)
        {
            if (entity.Id == default(int))
                _dbSet.Add(entity);
            else
                _db.Entry(entity).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Remove(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }

        public void InsertOnly(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;
        }
    }

}