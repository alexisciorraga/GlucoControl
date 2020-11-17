﻿using GlucoControl.Application.Services;
using GlucoControl.Domain.Model.Data.User;
using GlucoControl.Domain.Services;
using System;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Services
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserLogic _userLogic;

        public UserApplication(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public IEnumerable<User> GetAll()
        {
            return _userLogic.GetAll();
        }

        public User GetById(int entityId)
        {
            return _userLogic.GetById(entityId);
        }

        public User Login(string username, string password)
        {
            return _userLogic.Login(username, password);
        }
    }
}