using GlucoControl.Repository.Repositories.Base;
using System;

namespace GlucoControl.Repository.Repositories.Role
{
    public interface IRoleRepository : IBaseReadRepository<Model.Role, Guid>
    {
    }
}