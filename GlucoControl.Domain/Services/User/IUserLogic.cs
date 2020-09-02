using GlucoControl.Domain.Model.Data.User;
using GlucoControl.Domain.Services.Base;
using System;

namespace GlucoControl.Domain.Services
{
    public interface IUserLogic : IBaseServiceReadLogic<User, Guid>
    {
        User Login(string username, string password);
    }
}