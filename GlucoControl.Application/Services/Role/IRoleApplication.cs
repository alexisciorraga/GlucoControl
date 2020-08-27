using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.Role;
using System;

namespace GlucoControl.Application.Services
{
    public interface IRoleApplication : IBaseReadApplication<Role, Guid>
    {
    }
}