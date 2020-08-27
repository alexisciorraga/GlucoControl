using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.Role;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleLogic _roleLogic;

        public RoleApplication(IRoleLogic roleLogic)
        {
            _roleLogic = roleLogic;
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