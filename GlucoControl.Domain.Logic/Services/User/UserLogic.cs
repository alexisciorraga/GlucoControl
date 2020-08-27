using AutoMapper;
using GlucoControl.Domain.Model.Data.User;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Repositories.User;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class UserLogic : BaseServiceLogic<User, Repository.Model.User>, IUserLogic
    {
        private IUserRepository _userRepository;

        public UserLogic(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            _userRepository = userRepository;
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