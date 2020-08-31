using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;
using System.Collections.Generic;

namespace GlucoControl.Repository.Repositories
{
    public class ControlRepository : GenericRepository<Control>, IControlRepository
    {
        readonly GlucoControlDbContext _dbContext;
        public ControlRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
