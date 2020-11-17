using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.Role;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class RoleLogic : BaseServiceLogic<Role, Repository.Models.Role>, IRoleLogic
    {
        private IRoleRepository _roleRepository;

        public RoleLogic(IMapper mapper, IRoleRepository roleRepository) : base(mapper)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            return GetDomainEntitiesFromRepositoryEntities(_roleRepository.GetAll());
        }

        public Role GetById(int entityId)
        {
            var repositoryEntity = _roleRepository.GetById(entityId);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }
    }
}