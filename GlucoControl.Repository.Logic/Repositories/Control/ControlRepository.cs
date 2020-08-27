using GlucoControl.Repository.Logic.Repositories.Base;
using GlucoControl.Repository.Repositories.Control;
using System;

namespace GlucoControl.Repository.Logic.Repositories.Control
{
    public class ControlRepository : BaseRepositoryCrud<Model.Control, Guid>, IControlRepository
    {
        public ControlRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}