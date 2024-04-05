using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ASkillLevel
    {
        public ASkillLevel()
        {
            EmployeeSkills = new HashSet<EmployeeSkills>();
            NonStaffSkills = new HashSet<NonStaffSkills>();
        }

        public int SkillLevelId { get; set; }
        public string? SkillLevelDesc { get; set; }

        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; }
        public virtual ICollection<NonStaffSkills> NonStaffSkills { get; set; }
    }
}
