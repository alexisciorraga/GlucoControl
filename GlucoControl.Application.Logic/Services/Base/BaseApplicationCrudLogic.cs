using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Services.Base;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services.Base
{
    public class BaseApplicationCrudLogic<TEntity, TEntityKey> : IBaseApplicationCrud<TEntity, TEntityKey>
    {
        private readonly IBaseServiceCrudLogic<TEntity, TEntityKey> _baseServiceCrudLogic;
        private readonly IBaseServiceReadLogic<TEntity, TEntityKey> _baseServiceReadLogic;

        public BaseApplicationCrudLogic(IBaseServiceCrudLogic<TEntity, TEntityKey> baseServiceCrudLogic, IBaseServiceReadLogic<TEntity, TEntityKey> baseServiceReadLogic)
        {
            _baseServiceCrudLogic = baseServiceCrudLogic;
            _baseServiceReadLogic = baseServiceReadLogic;
        }

        public TEntity Add(TEntity entity)
        {
            return _baseServiceCrudLogic.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _baseServiceCrudLogic.Update(entity);
        }

        public void Delete(TEntityKey entityId)
        {
            _baseServiceCrudLogic.Delete(entityId);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _baseServiceReadLogic.GetAll();
        }

        public TEntity GetById(TEntityKey entityId)
        {
            return _baseServiceReadLogic.GetById(entityId);
        }
    }
}