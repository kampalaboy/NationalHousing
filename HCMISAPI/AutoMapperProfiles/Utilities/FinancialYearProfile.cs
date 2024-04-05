using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Utilities;

namespace HCMISAPI.AutoMapperProfiles.Utilities
{
    public class FinancialYearProfile : Profile
    {
        public FinancialYearProfile()
        {
            CreateMap<AFinancialYear, ViewFinancialYearDto>();

        }
    }
}
