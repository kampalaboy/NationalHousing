using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class CpdProfile : Profile
    {
       public CpdProfile()
        {
            CreateMap<TrainingCpd, ViewCpdDto>();

            CreateMap<CreateCpdDto, TrainingCpd>();

            CreateMap<UpdateCpdDto, TrainingCpd>();
        }
    }
}
