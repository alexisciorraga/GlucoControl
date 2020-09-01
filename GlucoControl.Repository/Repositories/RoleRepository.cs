using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public RoleRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}