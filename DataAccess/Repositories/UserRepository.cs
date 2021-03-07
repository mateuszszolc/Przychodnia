﻿using System;
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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {

        }

        public async Task<bool> AddUserAsync(User user)
        {
           User result= await AddAsync(user);
           if (result != null)
               return true;
           else
               return false;
        }

        public async Task<bool> RemoveUserAsync(User user)
        {
            User result= await DeleteAsync(user);
            if (result != null)
                return true;
            else
                return false;
        }

        public async Task<bool> CheckUniqueUser(string email)
        {
            return await GetAll().Where(x => x.Email == email).AnyAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Username == username);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.UserId == id);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
