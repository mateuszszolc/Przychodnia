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

       public async Task<bool> AddUserRoleAsync(UserRoles userRole)
       {
            var result= await AddAsync(userRole);
            if (result != null)
                return true;
            else
                return false;
       }

       public async Task<bool> RemoveUserRoleAsync(UserRoles userRole)
       {
           var result= await DeleteAsync(userRole);
           if (result != null)
               return true;
           else
               return false;
       }

   }
}
