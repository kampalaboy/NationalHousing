using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class TargetTeamProfile : Profile
    {
        public TargetTeamProfile()
        {
          CreateMap<TrainingATargetTeam, ViewTargetTeamDto>();
          CreateMap<TrainingATargetTeam, CreateTargetTeamDto>();
        }
    }
}
