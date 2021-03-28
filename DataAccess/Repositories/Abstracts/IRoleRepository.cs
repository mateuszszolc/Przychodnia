using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
   public interface IRoleRepository : IRepository<UserRoles>
    {
        public Task<UserRoles> AddRoleAsync(UserRoles userRole);

        public Task<UserRoles> UpdateUserRoleAsync(UserRoles entity);

        Task<List<UserRoles>> GetUserRolesByIdAsync(int userId);
        Task<UserRoles> RemoveUserRoleAsync(UserRoles userRole);

    }
}
