using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ABscPerformanceMeasurement
    {
        public ABscPerformanceMeasurement()
        {
            BalanceScoreCardTargetSetting = new HashSet<BalanceScoreCardTargetSetting>();
        }

        public int MeasurementMetricId { get; set; }
        public string? MeasurementMetricDescription { get; set; }

        public virtual ICollection<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; }
    }
}
