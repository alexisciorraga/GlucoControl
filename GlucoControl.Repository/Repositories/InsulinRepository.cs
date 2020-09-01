using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Repositories
{
    public class InsulinRepository : GenericRepository<Insulin>, IInsulinRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public InsulinRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}