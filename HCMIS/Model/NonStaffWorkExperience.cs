namespace HCMIS.Model
{
    public partial class NonStaffWorkExperience
    {
        public int WorkExperienceId { get; set; }
        public int NonStaffid { get; set; }
        public string? Organisation { get; set; }
        public string? JobTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string? EmployerName { get; set; }
        public string? EmployerOfficialEmail { get; set; }
        public double? EmployerOfficialNumber { get; set; }
        public string? AppointmentLetterUrl { get; set; }
        public string? AppointmentLetterExt { get; set; }
        public string? Responsibilities { get; set; }
    }
}
