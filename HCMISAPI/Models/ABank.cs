using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ABank
    {
        public ABank()
        {
            Employee = new HashSet<Employee>();
            NonStaff = new HashSet<NonStaff>();
        }

        public int BankId { get; set; }
        public string? BankDesc { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<NonStaff> NonStaff { get; set; }
    }
}
