namespace HCMIS.Model
{
    public partial class NonStaffNextOfKin
    {
        public int NonStaffNextOfKinId { get; set; }
        public int NonStaffid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public string? EmailAddress { get; set; }
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public int? RelationshipId { get; set; }
    }
}
