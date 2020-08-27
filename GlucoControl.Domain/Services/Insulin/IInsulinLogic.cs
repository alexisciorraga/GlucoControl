using GlucoControl.Domain.Model.Data.Insulin;
using GlucoControl.Domain.Services.Base;
using System;

namespace GlucoControl.Domain.Services
{
    public interface IInsulinLogic : IBaseServiceReadLogic<Insulin, Guid>
    {
    }
}