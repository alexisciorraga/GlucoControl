using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.Insulin;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class InsulinApplication : IInsulinApplication
    {
        private readonly IInsulinLogic _insulinLogic;

        public InsulinApplication(IInsulinLogic insulinLogic)
        {
            _insulinLogic = insulinLogic;
        }

        public IEnumerable<Insulin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Insulin GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}