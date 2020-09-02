using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;
using System.Linq;

namespace GlucoControl.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly GlucoControlDbContext _dbContext;

        public UserRepository(GlucoControlDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public User Login(string username, string password)
        {
            return _dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
        }
    }
}