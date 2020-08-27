using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GlucoControl.Repository.Logic.Repositories.Base
{
    public class BaseReadRepository<TUnitOfWork, TEntity, TEntityKey> : BaseRepository<TUnitOfWork, TEntity>
        where TUnitOfWork : DbContext
        where TEntity : class
    {
        public BaseReadRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity GetById(TEntityKey entityId)
        {
            return Context.Set<TEntity>().Find(entityId);
        }

        public bool ExistsId(TEntityKey id)
        {
            if (GetById(id) == null)
            {
                return false;
            }

            return true;
        }
    }
}