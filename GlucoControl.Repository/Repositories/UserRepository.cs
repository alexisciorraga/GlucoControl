using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public UserRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}