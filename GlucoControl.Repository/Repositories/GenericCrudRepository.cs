using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace GlucoControl.Repository.Repositories
{
    public class GenericCrudRepository<TEntity> :
        IGenericCrudRepository<TEntity> where TEntity : class
    {
        readonly GlucoControlDbContext _dbContext;
        //readonly ILogErrorRepository _logErrorRepository;

        private DbSet<TEntity> table = null;
        public GenericCrudRepository()
        {
            _dbContext = new GlucoControlDbContext(new DbContextOptions<GlucoControlDbContext> { });
            table = _dbContext.Set<TEntity>();
        }
        public GenericCrudRepository(GlucoControlDbContext dbContext/*, ILogErrorRepository logErrorRepository*/)
        {
            _dbContext = dbContext;
            //_logErrorRepository = logErrorRepository;
        }

        public TEntity Insert(TEntity obj)
        {
            try
            {
                if (table != null)
                {
                    return table.Add(obj).Entity;
                }
                else
                {
                    return _dbContext.Add(obj).Entity;
                }
            }
            catch (Exception ex)
            {
                //_logErrorRepository.LogError(ex);
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                if (table != null)
                {
                    table.Attach(obj);
                    _dbContext.Entry(obj).State = EntityState.Modified;
                }
                else
                {
                    _dbContext.Attach(obj);
                    _dbContext.Entry(obj).State = EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                //_logErrorRepository.LogError(ex);
                throw ex;
            }
        }

        public void Delete(object id)
        {
            try
            {
                if (table != null)
                {
                    TEntity existing = table.Find(id);
                    table.Remove(existing);
                }
                else
                {
                    TEntity existing = _dbContext.Set<TEntity>().Find(id);
                    _dbContext.Remove(existing);
                }
            }
            catch (Exception ex)
            {
                //_logErrorRepository.LogError(ex);
                throw ex;
            }
        }

        public void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void BulkInsert(IEnumerable<TEntity> objs)
        {
            foreach (var obj in objs)
            {
                Insert(obj);
            }
        }
    }
}
