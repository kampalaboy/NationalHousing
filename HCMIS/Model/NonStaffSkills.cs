namespace HCMIS.Model
{
    public partial class NonStaffSkills
    {
        public int ExtraSkillsId { get; set; }
        public int NonStaffid { get; set; }
        public string? SkillDescription { get; set; }
        public int? SkillLevelId { get; set; }
        public int? YearsofExperience { get; set; }
    }
}
