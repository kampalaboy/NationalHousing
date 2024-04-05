using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AAppraisalReason
    {
        public AAppraisalReason()
        {
            BalanceScoreCard = new HashSet<BalanceScoreCard>();
        }

        public int AppraisalReasonId { get; set; }
        public string? AppraisalReason { get; set; }

        public virtual ICollection<BalanceScoreCard> BalanceScoreCard { get; set; }
    }
}
