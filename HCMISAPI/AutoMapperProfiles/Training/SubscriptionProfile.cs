using AutoMapper;
using HCMISAPI.Models;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class SubscriptionProfile : Profile
    {
        public SubscriptionProfile()
		{
            CreateMap<TrainingSubscription, ViewSubscriptionDto>();

            CreateMap<CreateSubscriptionDto, TrainingSubscription>();

            CreateMap<UpdateSubscriptionDto, TrainingSubscription>();
        }
    }
}
