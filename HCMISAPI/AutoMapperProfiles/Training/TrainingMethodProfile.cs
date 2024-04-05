using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class TrainingMethodProfile : Profile
    {
        public TrainingMethodProfile()
        {
            CreateMap<TrainingAMethod, ViewTrainingMethodDto>();

            CreateMap<TrainingAMethod, UpdateTrainingMethodDto>();
        }
    }
}
