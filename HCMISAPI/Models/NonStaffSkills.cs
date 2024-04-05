using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class NonStaffSkills
    {
        public int ExtraSkillsId { get; set; }
        public int NonStaffid { get; set; }
        public string? SkillDescription { get; set; }
        public int? SkillLevelId { get; set; }
        public int? YearsofExperience { get; set; }

        public virtual NonStaff NonStaff { get; set; } = null!;
        public virtual ASkillLevel? SkillLevel { get; set; }
    }
}
