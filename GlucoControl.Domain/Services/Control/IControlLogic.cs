using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services.Base;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Services
{
    public interface IControlLogic : IBaseServiceReadLogic<Control, int>, IBaseServiceCrudLogic<Control, int>
    {
        IEnumerable<Control> GetControlsByUserId(int userId);
    }
}