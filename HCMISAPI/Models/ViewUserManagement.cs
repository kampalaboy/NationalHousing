using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ViewUserManagement
    {
        public string Id { get; set; } = null!;
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? NormalizedRoleName { get; set; }
        public int? NonStaffid { get; set; }
        public string FullName { get; set; } = null!;
        public int? GenderId { get; set; }
        public string? EmailAddress { get; set; }
        public double? OfficialPhoneNumber { get; set; }
        public double? MobileNumber { get; set; }
        public double? OfficePhoneNumber { get; set; }
    }
}
