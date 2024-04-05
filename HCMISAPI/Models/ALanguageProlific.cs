using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ALanguageProlific
    {
        public ALanguageProlific()
        {
            EmployeeLanguagesKnown = new HashSet<EmployeeLanguagesKnown>();
            NonStaffLanguagesKnown = new HashSet<NonStaffLanguagesKnown>();
        }

        public int LanguageProlificId { get; set; }
        public string? LanguageProlificDesc { get; set; }

        public virtual ICollection<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; }
        public virtual ICollection<NonStaffLanguagesKnown> NonStaffLanguagesKnown { get; set; }
    }
}
