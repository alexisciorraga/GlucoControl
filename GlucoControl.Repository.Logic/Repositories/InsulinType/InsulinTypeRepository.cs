using GlucoControl.Repository.Logic.Repositories.Base;
using GlucoControl.Repository.Repositories.InsulinType;
using System;

namespace GlucoControl.Repository.Logic.Repositories.InsulinType
{
    public class InsulinTypeRepository : BaseReadRepository<GlucoControlEntities, Model.InsulinType, Guid>, IInsulinTypeRepository
    {
        public InsulinTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}