using GlucoControl.Repository.Repositories.Base;
using System;

namespace GlucoControl.Repository.Repositories.Insulin
{
    public interface IInsulinRepository : IBaseReadRepository<Model.Insulin, Guid>
    {
    }
}