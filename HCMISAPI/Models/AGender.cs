using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AGender
    {
        public AGender()
        {
            Employee = new HashSet<Employee>();
            EmployeeNextOfKin = new HashSet<EmployeeNextOfKin>();
            NonStaff = new HashSet<NonStaff>();
            NonStaffNextOfKin = new HashSet<NonStaffNextOfKin>();
        }

        public int GenderId { get; set; }
        public string? GenderDesc { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<EmployeeNextOfKin> EmployeeNextOfKin { get; set; }
        public virtual ICollection<NonStaff> NonStaff { get; set; }
        public virtual ICollection<NonStaffNextOfKin> NonStaffNextOfKin { get; set; }
    }
}
