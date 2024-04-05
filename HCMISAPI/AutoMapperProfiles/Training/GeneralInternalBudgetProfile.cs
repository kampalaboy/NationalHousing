using AutoMapper;
using HCMISAPI.DTO.Training;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class GeneralInternalBudgetProfile : Profile
    {
        public GeneralInternalBudgetProfile()
        {
            CreateMap<TrainingGeneralInternalBudget, ViewGeneralInternalBudgetDto>();

            CreateMap<UpdateGeneralInternalBudgetDto, TrainingGeneralInternalBudget>();

            CreateMap<CreateGeneralInternalBudgetDto, TrainingGeneralInternalBudget>();
        }
    }
}
