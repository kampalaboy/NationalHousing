using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class BscPerspectivesProfile : Profile
    {
        public BscPerspectivesProfile()
        {
            CreateMap<ABscPerspectives, CreateBscPerspectivesDto>();

            CreateMap<ABscPerspectives, UpdateBscPerspectivesDto>();

            CreateMap<ABscPerspectives, ViewBscPerspectivesDto>();
        }
    }
}
