using GlucoControl.Application.Services.Base;
using GlucoControl.Domain.Model.Data.Insulin;
using System;

namespace GlucoControl.Application.Services
{
    public interface IInsulinApplication : IBaseReadApplication<Insulin, Guid>
    {
    }
}