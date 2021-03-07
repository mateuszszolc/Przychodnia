using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> AddUserAsync(User user);
        Task<bool> RemoveUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> CheckUniqueUser(string email);
    }
}
