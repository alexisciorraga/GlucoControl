using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoControl.Repository.Interfaces
{
    public interface IGenericCrudRepository<TEntity> where TEntity : class
    {
        void BulkInsert(IEnumerable<TEntity> objs);
        TEntity Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        void Save();
    }
}
