namespace HCMIS.Model
{
    public class NonStaffQualification
    {
        public int QualificationId { get; set; }
        public int NonStaffid { get; set; }
        public int? LevelofEducationId { get; set; }
        public int? FieldOfStudyId { get; set; }
        public string? OtherFieldOfStudy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string? QualificationDocumentName { get; set; }
        public string? QualificationDocumentExt { get; set; }
        public string? InstitutionName { get; set; }
    }
}
