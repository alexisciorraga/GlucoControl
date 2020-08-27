using GlucoControl.Repository.Logic.Repositories.Base;
using GlucoControl.Repository.Repositories.User;
using System;
using System.Linq;

namespace GlucoControl.Repository.Logic.Repositories.User
{
    public class UserRepository : BaseReadRepository<GlucoControlEntities, Model.User, Guid>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool Login(string userName, string password)
        {
            bool userLogged = false;
            var allUsers = GetAll();
            Model.User user = allUsers.FirstOrDefault(x => x.Username == userName && x.Password == password);

            if (user != null)
                userLogged = true;

            return userLogged;
        }
    }
}