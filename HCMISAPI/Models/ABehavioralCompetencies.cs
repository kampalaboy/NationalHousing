using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ABehavioralCompetencies
    {
        public ABehavioralCompetencies()
        {
            BalanceScoreCardBehavioral = new HashSet<BalanceScoreCardBehavioral>();
        }

        public int CompetenceId { get; set; }
        public string? CompetenceDescription { get; set; }

        public virtual ICollection<BalanceScoreCardBehavioral> BalanceScoreCardBehavioral { get; set; }
    }
}
