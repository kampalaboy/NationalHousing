using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class BehavioralCompetenciesProfile : Profile
    {
        public BehavioralCompetenciesProfile()
        {
            CreateMap<ABehavioralCompetencies, CreateBehavioralCompetenciesDto>();

            CreateMap<ABehavioralCompetencies, UpdateBehavioralCompetenciesDto>();

            CreateMap<ABehavioralCompetencies, ViewBehavioralCompetenciesDto>();

        }
    }
}