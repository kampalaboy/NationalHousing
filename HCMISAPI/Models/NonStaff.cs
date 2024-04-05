using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class NonStaff
    {
        public NonStaff()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            NonStaffLanguagesKnown = new HashSet<NonStaffLanguagesKnown>();
            NonStaffNextOfKin = new HashSet<NonStaffNextOfKin>();
            NonStaffQualification = new HashSet<NonStaffQualification>();
            NonStaffSkills = new HashSet<NonStaffSkills>();
            NonStaffWorkExperience = new HashSet<NonStaffWorkExperience>();
        }

        public int NonStaffid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? EmailAddress { get; set; }
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public double? OfficePhoneNumber { get; set; }
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

        public virtual ABank? Bank { get; set; }
        public virtual ACountry? Coutry { get; set; }
        public virtual AGender? Gender { get; set; }
        public virtual AIdentificationType? IdentificationType { get; set; }
        public virtual AMaritalStatus? MaritalStatus { get; set; }
        public virtual ADistrict? PlaceofOriginDistrict { get; set; }
        public virtual AParish? PlaceofOriginParish { get; set; }
        public virtual ASubCounty? PlaceofOriginSubCounty { get; set; }
        public virtual AVillage? PlaceofOriginVillage { get; set; }
        public virtual ADistrict? PlaceofResidenceDistrict { get; set; }
        public virtual AParish? PlaceofResidenceParish { get; set; }
        public virtual ASubCounty? PlaceofResidenceSubCounty { get; set; }
        public virtual AVillage? PlaceofResidenceVillage { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<NonStaffLanguagesKnown> NonStaffLanguagesKnown { get; set; }
        public virtual ICollection<NonStaffNextOfKin> NonStaffNextOfKin { get; set; }
        public virtual ICollection<NonStaffQualification> NonStaffQualification { get; set; }
        public virtual ICollection<NonStaffSkills> NonStaffSkills { get; set; }
        public virtual ICollection<NonStaffWorkExperience> NonStaffWorkExperience { get; set; }
    }
}
