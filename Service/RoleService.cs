using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstracts;
using Service.Abstracts;

namespace Service
{
   public class RoleService:IRoleService
   {
       private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<UserRoles> AddRoleAsync(UserRoles userRole)
        {
          return await _roleRepository.AddRoleAsync(userRole);
        }

        public async Task<UserRoles> UpdateUserRoleAsync(UserRoles userRole)
        {
            return await _roleRepository.UpdateUserRoleAsync(userRole);
        }

        public async Task<List<UserRoles>> GetUserRolesByIdAsync(int userId)
        {
            return await _roleRepository.GetUserRolesByIdAsync(userId);
        }

        public async Task<UserRoles> RemoveUserRoleAsync(UserRoles userRole)
        {
            return await _roleRepository.RemoveUserRoleAsync(userRole);
        }

    }
}
