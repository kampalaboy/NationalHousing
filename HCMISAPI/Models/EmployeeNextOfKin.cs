using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class EmployeeNextOfKin
    {
        public int EmployeeNextOfKinId { get; set; }
        public int Employeeid { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? GenderId { get; set; }
        public string? EmailAddress { get; set; }
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public int? RelationshipId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual AGender? Gender { get; set; }
        public virtual ARelationship? Relationship { get; set; }
    }
}
