using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AMaritalStatus
    {
        public AMaritalStatus()
        {
            Employee = new HashSet<Employee>();
            NonStaff = new HashSet<NonStaff>();
        }

        public int MaritalStatusId { get; set; }
        public string? MaritalStatusDescription { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<NonStaff> NonStaff { get; set; }
    }
}
