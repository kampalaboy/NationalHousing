using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ALevelofEducation
    {
        public ALevelofEducation()
        {
            EmployeeQualification = new HashSet<EmployeeQualification>();
            JobDescription = new HashSet<JobDescription>();
            JobDescriptionKnowledge = new HashSet<JobDescriptionKnowledge>();
            NonStaffQualification = new HashSet<NonStaffQualification>();
        }

        public int LevelofEducationId { get; set; }
        public string? LevelofEducationDesc { get; set; }

        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<JobDescription> JobDescription { get; set; }
        public virtual ICollection<JobDescriptionKnowledge> JobDescriptionKnowledge { get; set; }
        public virtual ICollection<NonStaffQualification> NonStaffQualification { get; set; }
    }
}
