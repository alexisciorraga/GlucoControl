using GlucoControl.Repository.Repositories.Base;
using System;

namespace GlucoControl.Repository.Repositories.InsulinType
{
    public interface IInsulinTypeRepository : IBaseReadRepository<Model.InsulinType, Guid>
    {
    }
}