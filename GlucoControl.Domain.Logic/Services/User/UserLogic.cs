using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.User;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class UserLogic : BaseServiceLogic<User, Repository.Models.User>, IUserLogic
    {
        private IUserRepository _userRepository;

        public UserLogic(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return GetDomainEntitiesFromRepositoryEntities(_userRepository.GetAll());
        }

        public User GetById(Guid entityId)
        {
            var repositoryEntity = _userRepository.GetById(entityId);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }

        public User Login(string username, string password)
        {
            var repositoryEntity = _userRepository.Login(username, password);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }
    }
}