using AutoMapper;
using GlucoControl.Domain.Model.Data.Role;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Repositories.Role;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class RoleLogic : BaseServiceLogic<Role, Repository.Model.Role>, IRoleLogic
    {
        IRoleRepository _roleRepository;

        public RoleLogic(IMapper mapper, IRoleRepository roleRepository) : base(mapper)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}