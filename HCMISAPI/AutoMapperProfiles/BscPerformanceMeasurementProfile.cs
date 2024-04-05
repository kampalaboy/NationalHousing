using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Models;

namespace HCMISAPI.AutoMapperProfiles
{
    public class BscPerformanceMeasurementProflie : Profile
    {
        public BscPerformanceMeasurementProflie()
        {
            CreateMap<ABscPerformanceMeasurement, CreateBscPerformanceMeasurementDto>();

            CreateMap<ABscPerformanceMeasurement, UpdateBscPerformanceMeasurementDto>();

            CreateMap<ABscPerformanceMeasurement, ViewBscPerformanceMeasurementDto>();

        }
    }
}
