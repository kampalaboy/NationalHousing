using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ACountry
    {
        public ACountry()
        {
            Employee = new HashSet<Employee>();
            NonStaff = new HashSet<NonStaff>();
        }

        public int CoutryId { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryDesc { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<NonStaff> NonStaff { get; set; }
    }
}
