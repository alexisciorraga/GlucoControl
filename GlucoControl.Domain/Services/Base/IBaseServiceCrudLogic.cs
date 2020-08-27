namespace GlucoControl.Domain.Services.Base
{
    public interface IBaseServiceCrudLogic<TEntity, TEntityKey>
    {
        TEntity Add(TEntity entity);

        void Delete(TEntityKey entityId);

        void Update(TEntity entity);
    }
}