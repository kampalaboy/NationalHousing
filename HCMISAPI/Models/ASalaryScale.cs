using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ASalaryScale
    {
        public ASalaryScale()
        {
            AMobilePhoneEntitlement = new HashSet<AMobilePhoneEntitlement>();
            APublicHolidayAllowance = new HashSet<APublicHolidayAllowance>();
            ASafariAllowance = new HashSet<ASafariAllowance>();
            ATravelAbroadAllowance = new HashSet<ATravelAbroadAllowance>();
            JobDescription = new HashSet<JobDescription>();
        }

        public int SalaryScaleId { get; set; }
        public string? SalaryScaleDescription { get; set; }
        public double? GrossSalaryAmount { get; set; }

        public virtual ICollection<AMobilePhoneEntitlement> AMobilePhoneEntitlement { get; set; }
        public virtual ICollection<APublicHolidayAllowance> APublicHolidayAllowance { get; set; }
        public virtual ICollection<ASafariAllowance> ASafariAllowance { get; set; }
        public virtual ICollection<ATravelAbroadAllowance> ATravelAbroadAllowance { get; set; }
        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}
