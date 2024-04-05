namespace HCMIS.Model
{
    public class PrimaryDataModel
    {
    }
    public class AMaritalStatus
    {
        public int MaritalStatusId { get; set; }
        public string? MaritalStatusDescription { get; set; }
    }
    public class AVillage
    {
        public int VillageId { get; set; }
        public string? ViallgeDescription { get; set; }
        public int? ParishId { get; set; }
    }
    public partial class ASubCounty
    {
        public int SubCountyId { get; set; }
        public string? SubCountyDescription { get; set; }
        public int? DistrictId { get; set; }
    }
    public partial class AParish
    {
        public int ParishId { get; set; }
        public int? SubCountyId { get; set; }
        public string? ParishDesc { get; set; }
    }
    public partial class ADistrict
    {
        public int DistrictId { get; set; }
        public string? DistrictDescription { get; set; }
        public int? CountryId { get; set; }
    }
    public partial class ABank
    {
        public int BankId { get; set; }
        public string? BankDesc { get; set; }
    }
    public partial class AFieldOfStudy
    {
        public int FieldOfStudyId { get; set; }
        public string? FieldOfStudyDesc { get; set; }
    }
    public partial class ALevelofEducation
    {
        public int LevelofEducationId { get; set; }
        public string? LevelofEducationDesc { get; set; }
    }
    public partial class ARelationship
    {
        public int RelationshipId { get; set; }
        public string? RelationshipName { get; set; }
    }
    public partial class ALanguageProlific
    {
        public int LanguageProlificId { get; set; }
        public string? LanguageProlificDesc { get; set; }
    }
    public partial class ALanguages
    {
        public int LanguageId { get; set; }
        public string? LanguageDesc { get; set; }
    }
    public partial class ADepartment
    {
        public int DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? ReportsTo { get; set; }
    }
    public partial class ViewOrgStructureJobTitle
    {
        public int JobTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public string? JobTitleDescription { get; set; }
        public int? ReportsTo { get; set; }
    }
    public partial class ViewOrgStructureDepartment
    {
        public int DepartmentId { get; set; }
        public string? DepartmentDescription { get; set; }
        public int? ReportsTo { get; set; }
    }
    public class HierarchicalDetails
    {
        public string Id { get; set; }
        public string FilllColor { get; set; }
        public string Border { get; set; }
        public string Label { get; set; }
        public List<string> ReportingPerson { get; set; }
    }
}
