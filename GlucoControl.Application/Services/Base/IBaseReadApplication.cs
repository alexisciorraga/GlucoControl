using System.Collections.Generic;

namespace GlucoControl.Application.Services.Base
{
    public interface IBaseReadApplication<TEntity, TEntityKey>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(TEntityKey entityId);
    }
}