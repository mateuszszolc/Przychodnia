
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Service.Abstracts
{
    public interface IUserService
    {
         Task<List<User>> GetAllUsersAsync();

         Task<User> GetUserByIdAsync(int id);
         Task<User> AddUserAsync(User user);
         Task<User> RemoveUserAsync(User user);
         Task<bool> CheckUniqueUser(string email);
         Task<User> GetUserByEmailAsync(string email);
         Task<User> GetUserByUsernameAsync(string username);
         Task<User> UpdateUserAsync(User user);
    }
}