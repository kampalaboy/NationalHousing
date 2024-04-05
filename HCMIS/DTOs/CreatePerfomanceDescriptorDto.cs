namespace HCMISAPI.DTO
{
    public class CreatePerfomanceDescriptorDto
    {
        public int PerformanceDescriptorId { get; set; }
        public string? PerformanceDescriptor { get; set; }
        public int? PerformanceScore { get; set; }
    }
}
