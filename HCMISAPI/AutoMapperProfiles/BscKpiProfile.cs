using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class BscKpiProfile : Profile
    {
        public BscKpiProfile ()
        {
            CreateMap<ABscKpi, CreateBscKpiDto>();

            CreateMap<ABscKpi, UpdateBscKpiDto> ();

            CreateMap<ABscKpi, ViewBscKpiDto> ();
        }
    }
}
