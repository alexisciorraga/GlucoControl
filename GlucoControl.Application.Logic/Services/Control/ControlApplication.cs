﻿using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class ControlApplication : IControlApplication
    {
        readonly IControlLogic _controlLogic;

        public ControlApplication(IControlLogic controlLogic)
        {
            _controlLogic = controlLogic;
        }

        public Control Add(Control entity)
        {
            return _controlLogic.Add(entity);
        }

        public void Delete(Guid entityId)
        {
            _controlLogic.Delete(entityId);
        }

        public IEnumerable<Control> GetAll()
        {
            return _controlLogic.GetAll();
        }

        public Control GetById(Guid entityId)
        {
            return _controlLogic.GetById(entityId);
        }

        public void Update(Control entity)
        {
            _controlLogic.Update(entity);
        }
    }
}