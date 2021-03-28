using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Models.Context;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
   public class RoleRepository: Repository<UserRoles>, IRoleRepository
   {
       public RoleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
       {
       }
       public async Task<List<UserRoles>> GetUserRolesByIdAsync(int userId)
       {
           return await GetAll().Where(x => x.User.UserId == userId).ToListAsync();
       }

       public async Task<UserRoles> AddRoleAsync(UserRoles userRole)
       {
           return await AddAsync(userRole);
       
       }

       public async Task<UserRoles> UpdateUserRoleAsync(UserRoles userRole)
       {
           return await UpdateAsync(userRole);
       }

       public async Task<UserRoles> RemoveUserRoleAsync(UserRoles userRole)
       { 
           return await DeleteAsync(userRole);
       }

   }
}
