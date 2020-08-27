using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class ControlApplication : IControlApplication
    {
        private readonly IControlLogic _controlLogic;

        public ControlApplication(IControlLogic controlLogic)
        {
            _controlLogic = controlLogic;
        }

        public Control Add(Control entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Control> GetAll()
        {
            throw new NotImplementedException();
        }

        public Control GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public void Update(Control entity)
        {
            throw new NotImplementedException();
        }
    }
}