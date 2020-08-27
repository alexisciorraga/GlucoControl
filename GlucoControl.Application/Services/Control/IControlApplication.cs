using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.Control;
using System;

namespace GlucoControl.Application.Services
{
    public interface IControlApplication : IBaseApplicationCrud<Control, Guid>
    {
    }
}