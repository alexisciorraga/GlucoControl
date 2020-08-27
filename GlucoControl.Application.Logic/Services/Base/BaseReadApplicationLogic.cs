using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Services.Base;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services.Base
{
    public class BaseReadApplicationLogic<TEntity, TEntityKey> : IBaseReadApplication<TEntity, TEntityKey>
    {
        private readonly IBaseServiceReadLogic<TEntity, TEntityKey> _baseServiceReadLogic;

        public BaseReadApplicationLogic(IBaseServiceReadLogic<TEntity, TEntityKey> baseServiceReadLogic)
        {
            _baseServiceReadLogic = baseServiceReadLogic;
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