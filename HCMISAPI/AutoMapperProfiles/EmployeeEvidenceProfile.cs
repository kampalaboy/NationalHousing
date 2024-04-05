using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class EmployeeEvidenceProfile : Profile
    {
        public EmployeeEvidenceProfile()
        {
            CreateMap<AEmployeeEvidence, CreateEmployeeEvidenceDto>();

            CreateMap<AEmployeeEvidence, UpdateEmployeeEvidenceDto>();

            CreateMap<AEmployeeEvidence, ViewEmployeeEvidenceDto>();
        }
    }
}
