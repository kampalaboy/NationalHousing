using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ABscKpi
    {
        public ABscKpi()
        {
            BalanceScoreCardTargetSetting = new HashSet<BalanceScoreCardTargetSetting>();
        }

        public int Bsckpiid { get; set; }
        public string? Bsckpidescription { get; set; }

        public virtual ICollection<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; }
    }
}
