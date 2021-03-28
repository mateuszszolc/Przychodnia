using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Models.Context;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
   public class HospitalRepository:Repository<Hospital>,IHospitalRepository
    {
        public HospitalRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public async Task<List<Hospital>> GetAllHospitalsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Hospital> AddAHospitalsync(Hospital hospital)
        {
            return await AddAsync(hospital);
        
        }
        public async Task<Hospital> UpdateHospitalAsync(Hospital hospital)
        {
            return await UpdateAsync(hospital);
          }
        public async Task<Hospital> RemoveHospitalAsync(Hospital hospital)
        {
            return await DeleteAsync(hospital);
        }
    }
}
