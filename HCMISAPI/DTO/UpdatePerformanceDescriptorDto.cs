namespace HCMISAPI.DTO
{
    public class UpdatePerformanceDescriptorDto
    {
        public int PerformanceDescriptorId { get; set; }
        public string? PerformanceDescriptor { get; set; }
        public int? PerformanceScore { get; set; }
    }
}
