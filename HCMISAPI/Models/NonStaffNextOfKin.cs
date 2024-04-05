using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
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

        public virtual AGender? Gender { get; set; }
        public virtual NonStaff NonStaff { get; set; } = null!;
        public virtual ARelationship? Relationship { get; set; }
    }
}
