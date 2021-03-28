using System.Threading.Tasks;
using DataAccess.Models;

namespace Service.Abstracts
{
    public interface IDiagnosisService
    {
        Task<Diagnosis> AddDiagnosisAsync(Diagnosis diagnosis);
        Task<Diagnosis> UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task<Diagnosis> RemoveDiagnosisAsync(Diagnosis diagnosis);
    }
}