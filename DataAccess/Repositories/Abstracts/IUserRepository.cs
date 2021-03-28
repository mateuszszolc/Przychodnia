using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> AddUserAsync(User user);
        Task<User> RemoveUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
        Task<List<User>> GetAllUsersAsync();
        Task<User> UpdateUserAsync(User entity);
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> CheckUniqueUser(string email);
        Task<User> GetUserByUsernameAsync(string username);
    }
}
