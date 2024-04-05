using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ATravelClass
    {
        public ATravelClass()
        {
            ATravelAbroadAllowance = new HashSet<ATravelAbroadAllowance>();
        }

        public int TravelClassId { get; set; }
        public string? TravelClassDescription { get; set; }

        public virtual ICollection<ATravelAbroadAllowance> ATravelAbroadAllowance { get; set; }
    }
}
