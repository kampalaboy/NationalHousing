using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class Exit
    {
        public int ExitId { get; set; }
        public int? Employeeid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? Logoff { get; set; }
        public string? Feedback { get; set; }
        public string? Experience { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
