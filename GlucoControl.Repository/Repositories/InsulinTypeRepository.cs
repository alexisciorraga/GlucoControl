using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Repositories
{
    public class InsulinTypeRepository : GenericRepository<InsulinType>, IInsulinTypeRepository
    {
        readonly GlucoControlDbContext _dbContext;
        public InsulinTypeRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
