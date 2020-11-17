using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.Control;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Services
{
    public interface IControlApplication : IBaseReadApplication<Control, int>, IBaseApplicationCrud<Control, int>
    {
        IEnumerable<Control> GetControlsByUserId(int userId);
    }
}