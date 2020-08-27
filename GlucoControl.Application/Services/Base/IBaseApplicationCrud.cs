namespace GlucoControl.Application.Services.Base
{
    public interface IBaseApplicationCrud<TEntity, TEntityKey> : IBaseReadApplication<TEntity, TEntityKey>
    {
        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntityKey entityId);
    }
}