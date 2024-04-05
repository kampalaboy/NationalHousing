using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            EmployeeLanguagesKnown = new HashSet<EmployeeLanguagesKnown>();
            EmployeeNextOfKin = new HashSet<EmployeeNextOfKin>();
            EmployeeQualification = new HashSet<EmployeeQualification>();
            EmployeeSkills = new HashSet<EmployeeSkills>();
            EmployeeWorkExperience = new HashSet<EmployeeWorkExperience>();
            Exit = new HashSet<Exit>();
            TrainingSubscription = new HashSet<TrainingSubscription>();
        }

        public int Employeeid { get; set; }
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
        public int? JobDescriptionId { get; set; }
        public int? DepartmentId { get; set; }
        public string? EmployeeNumber { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DepartureDate { get; set; }

        public virtual ABank? Bank { get; set; }
        public virtual ACountry? Coutry { get; set; }
        public virtual ADepartment? Department { get; set; }
        public virtual AGender? Gender { get; set; }
        public virtual AIdentificationType? IdentificationType { get; set; }
        public virtual JobDescription? JobDescription { get; set; }
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
        public virtual ICollection<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; }
        public virtual ICollection<EmployeeNextOfKin> EmployeeNextOfKin { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<EmployeeSkills> EmployeeSkills { get; set; }
        public virtual ICollection<EmployeeWorkExperience> EmployeeWorkExperience { get; set; }
        public virtual ICollection<Exit> Exit { get; set; }
        public virtual ICollection<TrainingSubscription> TrainingSubscription { get; set; }
    }
}
