using GlucoControl.Repository.Models;
using System;
using System.Collections.Generic;

namespace GlucoControl.Repository.Interfaces
{
    public interface IControlRepository : IGenericRepository<Control>
    {
        IEnumerable<Control> GetControlsByUserId(int userId);
    }
}