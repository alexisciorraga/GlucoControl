using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.Control;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Services
{
    public interface IControlApplication : IBaseReadApplication<Control, Guid>, IBaseApplicationCrud<Control, Guid>
    {
        IEnumerable<Control> GetControlsByUserId(Guid userId);
    }
}