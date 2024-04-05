using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AIdentificationType
    {
        public AIdentificationType()
        {
            Employee = new HashSet<Employee>();
            NonStaff = new HashSet<NonStaff>();
        }

        public int IdentificationTypeId { get; set; }
        public string? IdentificationTypeDesc { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<NonStaff> NonStaff { get; set; }
    }
}
