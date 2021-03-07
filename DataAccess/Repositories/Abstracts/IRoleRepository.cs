using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
    interface IRoleRepository : IRepository<UserRoles>
    {
        public Task<UserRoles> AddAsync(UserRoles entity);

        public IQueryable<UserRoles> GetAll();

        public Task<UserRoles> UpdateAsync(UserRoles entity);

        Task<List<UserRoles>> GetUserRolesByIdAsync(int userId);
        Task<bool> AddUserRoleAsync(UserRoles userRole);
        Task<bool> RemoveUserRoleAsync(UserRoles userRole);

    }
}
