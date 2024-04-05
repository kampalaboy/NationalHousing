using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ABscPerspectives
    {
        public ABscPerspectives()
        {
            BalanceScoreCardTargetSetting = new HashSet<BalanceScoreCardTargetSetting>();
        }

        public int BscPerspectiveId { get; set; }
        public string? BscPerspectiveDescription { get; set; }
        public double? PerspectiveTotalWeight { get; set; }

        public virtual ICollection<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; }
    }
}
