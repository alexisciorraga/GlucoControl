using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GlucoControl.Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly GlucoControlDbContext _dbContext;
        //readonly ILogErrorRepository _logErrorRepository;

        private DbSet<TEntity> table = null;

        public GenericRepository()
        {
            //_dbContext = new GlucoControlDbContext(new DbContextOptions<GlucoControlDbContext> { });
            // _dbContext = new GlucoControlDbContext();
            table = _dbContext.Set<TEntity>();
        }

        public GenericRepository(GlucoControlDbContext dbContext/*, ILogErrorRepository logErrorRepository*/)
        {
            _dbContext = dbContext;
            //_logErrorRepository = logErrorRepository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                if (table != null)
                {
                    return table.ToList();
                }
                else
                {
                    return _dbContext.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                //_logErrorRepository.LogError(ex);
                throw ex;
            }
        }

        public TEntity GetById(object id)
        {
            try
            {
                if (table != null)
                {
                    return table.Find(id);
                }
                else
                {
                    return _dbContext.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                //_logErrorRepository.LogError(ex);
                throw ex;
            }
        }

        public TEntity Insert(TEntity obj)
        {
            try
            {
                TEntity entityInserted = null;

                if (table != null)
                {
                    entityInserted = table.Add(obj).Entity;
                    Save();
                    return entityInserted;
                }
                else
                {
                    entityInserted = _dbContext.Add(obj).Entity;
                    Save();
                    return entityInserted;
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