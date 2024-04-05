using AutoMapper;
using HCMISAPI.DTO.Training;
using HCMISAPI.Models;
namespace HCMISAPI.AutoMapperProfiles.Training
{
    public class ProfessionalAssociationProfile : Profile
    {
        public ProfessionalAssociationProfile()
        {
            CreateMap<TrainingAProfessionalAssociation, ViewProfessionalAssociationDto>();
        }
    }
}
