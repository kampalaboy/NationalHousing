using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class BalanceScoreCard
    {
        public BalanceScoreCard()
        {
            BalanceScoreCardBehavioral = new HashSet<BalanceScoreCardBehavioral>();
            BalanceScoreCardTargetSetting = new HashSet<BalanceScoreCardTargetSetting>();
        }

        public int BalanceScoreCardId { get; set; }
        public int? Employeeid { get; set; }
        public int? AppraisalReasonId { get; set; }
        public DateTime? DateofReview { get; set; }
        public int? AppraiserName { get; set; }
        public int? JobTitleId { get; set; }

        public virtual AAppraisalReason? AppraisalReason { get; set; }
        public virtual AJobTitle? JobTitle { get; set; }
        public virtual ICollection<BalanceScoreCardBehavioral> BalanceScoreCardBehavioral { get; set; }
        public virtual ICollection<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; }
    }
}
