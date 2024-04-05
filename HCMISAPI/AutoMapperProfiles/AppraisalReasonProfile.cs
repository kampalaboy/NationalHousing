using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class AppraisalReasonProfile : Profile
    {
        public AppraisalReasonProfile()
        {
            CreateMap<AAppraisalReason, CreateAppraisalReasonDto>();

            CreateMap<AAppraisalReason, UpdateAppraisalReasonDto>();

            CreateMap<AAppraisalReason, ViewAppraisalReasonDto>();

        }
    }
}
