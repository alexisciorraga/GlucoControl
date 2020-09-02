using GlucoControl.Repository.Models;

namespace GlucoControl.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Login(string username, string password);
    }
}