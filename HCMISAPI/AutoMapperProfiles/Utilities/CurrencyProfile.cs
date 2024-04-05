using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Utilities;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<ACurrency, ViewCurrencyDto>();
             
        }
    }
}