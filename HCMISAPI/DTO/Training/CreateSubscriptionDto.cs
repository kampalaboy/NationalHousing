using HCMISAPI.Models;

namespace HCMISAPI.DTO.Training
{
	public class CreateSubscriptionDto
	{
        public int? EmployeeId { get; set; }
        public int? ProfessionalAssociation { get; set; }
        public string? CourseDetails { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Currency { get; set; }
        public double? AmountPaid { get; set; }
    }
}
