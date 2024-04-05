using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AMobilePhoneEntitlement
    {
        public int MobilePhoneEntitlementId { get; set; }
        public int? SalaryScaleId { get; set; }
        public double? EntitlementFee { get; set; }

        public virtual ASalaryScale? SalaryScale { get; set; }
    }
}
