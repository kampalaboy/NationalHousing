using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class APerformanceDescriptor
    {
        public APerformanceDescriptor()
        {
            BalanceScoreCardBehavioral = new HashSet<BalanceScoreCardBehavioral>();
        }

        public int PerformanceDescriptorId { get; set; }
        public string? PerformanceDescriptor { get; set; }
        public int? PerformanceScore { get; set; }

        public virtual ICollection<BalanceScoreCardBehavioral> BalanceScoreCardBehavioral { get; set; }
    }
}
