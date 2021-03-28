using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
    public interface IDiagnosesRepository : IRepository<Diagnosis>
    {
        Task<Diagnosis> AddDiagnosisAsync(Diagnosis diagnosis);
        Task<Diagnosis> UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task<Diagnosis> RemoveDiagnosisAsync(Diagnosis diagnosis);
    }
}
