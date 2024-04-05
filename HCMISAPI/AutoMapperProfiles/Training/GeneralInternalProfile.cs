using AutoMapper;
using HCMISAPI.DTO.Training;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class GeneralInternalProfile : Profile
    {
        public GeneralInternalProfile()
        {
            CreateMap<TrainingGeneralInternal, ViewGeneralInternalDto>();  

            CreateMap<UpdateGeneralInternalDto, TrainingGeneralInternal>()
                .ReverseMap();

            CreateMap<CreateGeneralInternalDto, TrainingGeneralInternal>();
        }
    }
}
