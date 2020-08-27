using GlucoControl.Repository.Repositories.Base;
using System;

namespace GlucoControl.Repository.Repositories.User
{
    public interface IUserRepository : IBaseReadRepository<Model.User, Guid>
    {
        bool Login(string userName, string password);
    }
}