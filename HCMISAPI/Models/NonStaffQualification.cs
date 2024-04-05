using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class NonStaffQualification
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

        public virtual AFieldOfStudy? FieldOfStudy { get; set; }
        public virtual ALevelofEducation? LevelofEducation { get; set; }
        public virtual NonStaff NonStaff { get; set; } = null!;
    }
}
