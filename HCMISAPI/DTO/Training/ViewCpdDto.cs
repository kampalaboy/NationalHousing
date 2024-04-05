namespace HCMISAPI.DTO.Training
{
    public class ViewCpdDto
    {
        public int Id { get; set; }
        public string? Module { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }
        public string? Departments { get; set; }
        public string? Officers { get; set; }
        public double? Amount { get; set; }
        public string? Trainer { get; set; }
    }
}
