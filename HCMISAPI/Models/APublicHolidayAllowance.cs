using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class APublicHolidayAllowance
    {
        public int PublicHolidayAllowanceId { get; set; }
        public int SalaryScaleId { get; set; }
        public double? PublicHolidayAllowanceGrossFee { get; set; }
        public double? TaxAmount { get; set; }
        public double? PublicHolidayAllowanceNetFee { get; set; }

        public virtual ASalaryScale SalaryScale { get; set; } = null!;
    }
}
