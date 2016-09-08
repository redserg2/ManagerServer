using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace SqlDBConnector
{
    public class RepositoryBase<T> : IDisposable
        where T : DbContext, new()
    {
        private T _context;
        private static Logger LoggerHelper = LogManager.GetCurrentClassLogger();

        public RepositoryBase()
        {
            _context = new T();
        }

        public RepositoryBase(T context)
        {
            _context = context;
        }
    
        public virtual TEntity Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return _context.Set<TEntity>().Where(predicate).SingleOrDefault();
        }

        public virtual IQueryable<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            try
            {
                return _context.Set<TEntity>().Where(predicate);
            }
            catch (Exception ex)
            {
                LoggerHelper.ErrorException(ex.Message, ex);
            }
            return null;
        }

        public virtual IQueryable<TEntity> GetList<TEntity, TKey>(Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> orderBy) where TEntity : class
        {
            try
            {
                return GetList(predicate).OrderBy(orderBy);
            }
            catch (Exception ex)
            {
                //Log error
                LoggerHelper.ErrorException(ex.Message, ex);
            }
            return null;
        }

        public virtual IQueryable<TEntity> GetList<TEntity, TKey>(Expression<Func<TEntity, TKey>> orderBy) where TEntity : class
        {
            try
            {
                return GetList<TEntity>().OrderBy(orderBy);
            }
            catch (Exception ex)
            {
                //Log error
                LoggerHelper.ErrorException(ex.Message, ex);
            }
            return null;
        }

        public virtual IQueryable<TEntity> GetList<TEntity>() where TEntity : class
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                //Log error
                LoggerHelper.ErrorException(ex.Message, ex);
            }
            return null;
        }

        public virtual bool Save<TEntity>(TEntity entity) where TEntity : class
        {

            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                LoggerHelper.ErrorException("Error saving " + typeof(TEntity) + ".", ex);
                throw;
            }

        }

        public virtual bool Update<TEntity>(TEntity entity, params string[] propsToUpdate) where TEntity : class
        {
            try
            {
                _context.Set<TEntity>().Attach(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                LoggerHelper.ErrorException("Error saving " + typeof(TEntity) + ".", ex);
                throw;
            }
        }

        protected virtual bool Delete<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                ObjectSet<TEntity> objectSet = ((IObjectContextAdapter)_context).ObjectContext.CreateObjectSet<TEntity>();
                objectSet.Attach(entity);
                objectSet.DeleteObject(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                LoggerHelper.ErrorException("Error deleting " + typeof(TEntity), ex);
                throw;
            }

        }

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }
    }
}
