using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Service.Abstracts
{
    public interface IHospitalService
    {
        Task<List<Hospital>> GetAllHospitalsAsync();
        Task<Hospital> AddAHospitalsync(Hospital hospital);
        Task<Hospital> UpdateHospitalAsync(Hospital hospital);
        Task<Hospital> RemoveHospitalAsync(Hospital hospital);
    }
}