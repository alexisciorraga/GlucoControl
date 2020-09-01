using System.Collections.Generic;

namespace GlucoControl.Domain.Services.Base
{
    public interface IBaseServiceReadLogic<TEntity, TEntityKey>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(TEntityKey entityId);
    }
}