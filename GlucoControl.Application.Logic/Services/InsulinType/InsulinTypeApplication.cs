using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.InsulinType;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class InsulinTypeApplication : IInsulinTypeApplication
    {
        private readonly IInsulinTypeLogic _insulinTypeLogic;

        public InsulinTypeApplication(IInsulinTypeLogic insulinTypeLogic)
        {
            _insulinTypeLogic = insulinTypeLogic;
        }

        public IEnumerable<InsulinType> GetAll()
        {
            return _insulinTypeLogic.GetAll();
        }

        public InsulinType GetById(int entityId)
        {
            return _insulinTypeLogic.GetById(entityId);
        }
    }
}