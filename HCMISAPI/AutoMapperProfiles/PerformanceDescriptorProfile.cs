using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class PerformanceDescriptorProfile : Profile
    {
        public PerformanceDescriptorProfile()
        {
            CreateMap<APerformanceDescriptor, CreatePerfomanceDescriptorDto>();

            CreateMap<APerformanceDescriptor, UpdatePerformanceDescriptorDto>();

            CreateMap<APerformanceDescriptor, ViewPerformanceDescriptorDto>();

        }
    }
}
