using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services.Base;
using System;

namespace GlucoControl.Domain.Services
{
    public interface IControlLogic : IBaseServiceReadLogic<Control, Guid>, IBaseServiceCrudLogic<Control, Guid>
    {
    }
}