using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.User;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserLogic _userLogic;

        public UserApplication(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}