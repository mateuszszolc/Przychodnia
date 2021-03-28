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
    public class DiagnosesRepository:Repository<Diagnosis>,IDiagnosesRepository
    {
        public DiagnosesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<Diagnosis> AddDiagnosisAsync(Diagnosis diagnosis)
        {
            return await AddAsync(diagnosis);
           
        }
        public async Task<Diagnosis> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            return await UpdateAsync(diagnosis);
      
        }
        public async Task<Diagnosis> RemoveDiagnosisAsync(Diagnosis diagnosis)
        {
            return await DeleteAsync(diagnosis);
        }
    }
}
