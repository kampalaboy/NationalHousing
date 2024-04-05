using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ALanguages
    {
        public ALanguages()
        {
            EmployeeLanguagesKnown = new HashSet<EmployeeLanguagesKnown>();
            NonStaffLanguagesKnown = new HashSet<NonStaffLanguagesKnown>();
        }

        public int LanguageId { get; set; }
        public string? LanguageDesc { get; set; }

        public virtual ICollection<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; }
        public virtual ICollection<NonStaffLanguagesKnown> NonStaffLanguagesKnown { get; set; }
    }
}
