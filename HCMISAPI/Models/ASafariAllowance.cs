using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ASafariAllowance
    {
        public int SafariAllowanceId { get; set; }
        public int SalaryScaleId { get; set; }
        public double? DayAllowanceFee { get; set; }
        public double? NightAllowanceFee { get; set; }

        public virtual ASalaryScale SalaryScale { get; set; } = null!;
    }
}
