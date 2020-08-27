using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.User;
using System;

namespace GlucoControl.Application.Services
{
    public interface IUserApplication : IBaseReadApplication<User, Guid>
    {
    }
}