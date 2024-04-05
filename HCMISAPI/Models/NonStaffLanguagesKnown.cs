using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class NonStaffLanguagesKnown
    {
        public int LanguagesKnownId { get; set; }
        public int NonStaffid { get; set; }
        public int LanguageId { get; set; }
        public int? LanguageProlificId { get; set; }

        public virtual ALanguages? LanguageProlific { get; set; }
        public virtual ALanguageProlific? LanguageProlificNavigation { get; set; }
        public virtual NonStaff NonStaff { get; set; } = null!;
    }
}
