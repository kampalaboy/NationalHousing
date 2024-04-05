using HCMIS.Model;

namespace HCMIS.ViewModel
{
    public class ExternalRegistrationModel
    {
        public List<ACountry>? Coutry { get; set; }
        public List<AGender>? Gender { get; set; }
        public List<AIdentificationType>? IdentificationType { get; set; }
        public List<ADistrict>? District { get; set; }
        public List<AParish>? Parish { get; set; }
        public List<ASubCounty>? SubCounty { get; set; }
        public List<AVillage>? Village { get; set; }
        public List<AMaritalStatus>? MaritalStatus { get; set; }
        public List<ABank>? Bank { get; set; }
        public List<AFieldOfStudy>? FieldOfStudy { get; set; }
        public List<ALevelofEducation>? LevelofEducation { get; set; }
        public List<ASkillLevel>? SkillLevel { get; set; }
        public List<ARelationship>? Relationship { get; set; }
        public List<ALanguageProlific>? LanguageProlific { get; set; }
        public List<ALanguages>? Languages { get; set; }
    }
}
