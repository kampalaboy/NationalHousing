using System.ComponentModel.DataAnnotations;

namespace HCMIS.Model
{
    public class NonStaff
    {
        public int NonStaffid { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public int? GenderId { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime? DoB { get; set; }
        [Required(ErrorMessage = "Identification Type is required")]
        public int? IdentificationTypeId { get; set; }
        [Required(ErrorMessage = "Identification Number is required")]
        public string? IdentificationNumber { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        public string? EmailAddress { get; set; }
        [Required(ErrorMessage = "Official Phone number is required")]
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public double? OfficePhoneNumber { get; set; }
        [Required(ErrorMessage = "Nationality is required")]
        public int? CoutryId { get; set; }
        public string? LinkedIn { get; set; }
        public string? Github { get; set; }
        public string? Twitter { get; set; }
        public string? CvdocumentName { get; set; }
        public string? CvdocumentExt { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? PlaceofOriginDistrictId { get; set; }
        public int? PlaceofOriginSubCountyId { get; set; }
        public int? PlaceofOriginParishId { get; set; }
        public int? PlaceofOriginVillageId { get; set; }
        public int? PlaceofResidenceDistrictId { get; set; }
        public int? PlaceofResidenceSubCountyId { get; set; }
        public int? PlaceofResidenceParishId { get; set; }
        public int? PlaceofResidenceVillageId { get; set; }
        public string? Nssfno { get; set; }
        public string? UraTinNo { get; set; }
        public int? BankId { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? Photograph { get; set; }
        public string? PhotographExt { get; set; }
    }
}
