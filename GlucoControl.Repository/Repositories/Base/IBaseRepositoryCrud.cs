namespace GlucoControl.Repository.Repositories.Base
{
    public interface IBaseRepositoryCrud<TEntity, TEntityKey> : IBaseReadRepository<TEntity, TEntityKey> where TEntity : class
    {
        TEntity Add(TEntity entity);

        void Delete(TEntity entity);

        int Update(TEntity entityToUpdate);

        //bool MassiveInsert(IEnumerable<TEntity> collectionEntities);
        //bool MassiveDelete(IEnumerable<TEntity> collectionEntities);
    }
}