using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.InsulinType;
using System;

namespace GlucoControl.Application.Services
{
    public interface IInsulinTypeApplication : IBaseReadApplication<InsulinType, Guid>
    {
    }
}