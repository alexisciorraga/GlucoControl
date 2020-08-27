using GlucoControl.Repository.Logic.Repositories.Base;
using GlucoControl.Repository.Repositories.Role;
using System;

namespace GlucoControl.Repository.Logic.Repositories.Role
{
    public class RoleRepository : BaseReadRepository<GlucoControlEntities, Model.Role, Guid>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}