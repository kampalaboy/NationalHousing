using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class EmployeeQualification
    {
        public int QualificationId { get; set; }
        public int Employeeid { get; set; }
        public int? LevelofEducationId { get; set; }
        public int? FieldOfStudyId { get; set; }
        public string? OtherFieldOfStudy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string? QualificationDocumentName { get; set; }
        public string? QualificationDocumentExt { get; set; }
        public string? InstitutionName { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual AFieldOfStudy? FieldOfStudy { get; set; }
        public virtual ALevelofEducation? LevelofEducation { get; set; }
    }
}
