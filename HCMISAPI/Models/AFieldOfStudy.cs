using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AFieldOfStudy
    {
        public AFieldOfStudy()
        {
            EmployeeQualification = new HashSet<EmployeeQualification>();
            JobDescriptionKnowledge = new HashSet<JobDescriptionKnowledge>();
            NonStaffQualification = new HashSet<NonStaffQualification>();
        }

        public int FieldOfStudyId { get; set; }
        public string? FieldOfStudyDesc { get; set; }

        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<JobDescriptionKnowledge> JobDescriptionKnowledge { get; set; }
        public virtual ICollection<NonStaffQualification> NonStaffQualification { get; set; }
    }
}
