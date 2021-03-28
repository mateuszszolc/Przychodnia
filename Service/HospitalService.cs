using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Repositories.Abstracts;
using Service.Abstracts;

namespace Service
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _hospitalRepository;
        public HospitalService(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public async Task<Hospital> AddAHospitalsync(Hospital hospital)
        {
          return await _hospitalRepository.AddAHospitalsync(hospital);
        }

        public async Task<List<Hospital>> GetAllHospitalsAsync()
        {
            return await  _hospitalRepository.GetAllHospitalsAsync();
        }

        public async Task<Hospital> RemoveHospitalAsync(Hospital hospital)
        {
            return await  _hospitalRepository.RemoveHospitalAsync(hospital);
        }

        public async Task<Hospital> UpdateHospitalAsync(Hospital hospital)
        {
            return await  _hospitalRepository.UpdateHospitalAsync(hospital);
        }
    }
}
