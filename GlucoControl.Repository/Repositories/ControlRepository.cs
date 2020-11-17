using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GlucoControl.Repository.Repositories
{
    public class ControlRepository : GenericRepository<Control>, IControlRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public ControlRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Control> GetControlsByUserId(int userId)
        {
            return _dbContext.Controls.Where(c => c.UserId == userId).ToList();
        }
    }
}