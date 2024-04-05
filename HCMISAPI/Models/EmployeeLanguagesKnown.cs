using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class EmployeeLanguagesKnown
    {
        public int LanguagesKnownId { get; set; }
        public int Employeeid { get; set; }
        public int LanguageId { get; set; }
        public int? LanguageProlificId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ALanguages? LanguageProlific { get; set; }
        public virtual ALanguageProlific? LanguageProlificNavigation { get; set; }
    }
}
