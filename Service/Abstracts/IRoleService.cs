using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Service.Abstracts
{
    public interface IRoleService
    {
        Task<UserRoles> AddRoleAsync(UserRoles userRole);
        Task<UserRoles> UpdateUserRoleAsync(UserRoles userRole);
        Task<List<UserRoles>> GetUserRolesByIdAsync(int userId);
        Task<UserRoles> RemoveUserRoleAsync(UserRoles userRole);
    }
}