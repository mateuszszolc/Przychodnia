using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Repositories.Abstracts;
using Service.Abstracts;

namespace Service
{
    public class DiagnosisService : IDiagnosisService
    {
        private readonly IDiagnosesRepository _diagnosesRepository;
        public DiagnosisService(IDiagnosesRepository diagnosesRepository)
        {
            _diagnosesRepository = diagnosesRepository;
        }

        public async Task<Diagnosis> AddDiagnosisAsync(Diagnosis diagnosis)
        {
           return await _diagnosesRepository.AddDiagnosisAsync(diagnosis);
        }

        public async Task<Diagnosis> RemoveDiagnosisAsync(Diagnosis diagnosis)
        {
            return await _diagnosesRepository.RemoveDiagnosisAsync(diagnosis);
        }

        public async Task<Diagnosis> UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            return await _diagnosesRepository.RemoveDiagnosisAsync(diagnosis);
        }
    }
}
