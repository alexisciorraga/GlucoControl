using GlucoControl.Repository.Logic.Repositories.Base;
using GlucoControl.Repository.Repositories.Insulin;
using System;

namespace GlucoControl.Repository.Logic.Repositories.Insulin
{
    public class InsulinRepository : BaseReadRepository<GlucoControlEntities, Model.Insulin, Guid>, IInsulinRepository
    {
        public InsulinRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}