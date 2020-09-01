using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Repositories
{
    public class ControlRepository : GenericRepository<Control>, IControlRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public ControlRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}