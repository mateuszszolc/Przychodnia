using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
    public interface IHospitalRepository
    {
        Task<List<Hospital>> GetAllHospitalsAsync();
        Task<Hospital> AddAHospitalsync(Hospital hospital);
        Task<Hospital> UpdateHospitalAsync(Hospital hospital);
        Task<Hospital> RemoveHospitalAsync(Hospital hospital);
    }
}