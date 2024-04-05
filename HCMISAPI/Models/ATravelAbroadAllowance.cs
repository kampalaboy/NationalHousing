using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ATravelAbroadAllowance
    {
        public int TravelAbroadAllowanceId { get; set; }
        public int SalaryScaleId { get; set; }
        public double? DailyEntitlementFee { get; set; }
        public int? TravelClassId { get; set; }

        public virtual ASalaryScale SalaryScale { get; set; } = null!;
        public virtual ATravelClass? TravelClass { get; set; }
    }
}
