using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AEmployeeEvidence
    {
        public AEmployeeEvidence()
        {
            BalanceScoreCardTargetSetting = new HashSet<BalanceScoreCardTargetSetting>();
        }

        public int EvidenceId { get; set; }
        public string? EvidenceDescription { get; set; }

        public virtual ICollection<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; }
    }
}
