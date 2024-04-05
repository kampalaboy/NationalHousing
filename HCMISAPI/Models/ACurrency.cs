using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class ACurrency
    {
        public ACurrency()
        {
            TrainingSubscription = new HashSet<TrainingSubscription>();
        }

        public string IsoCode { get; set; } = null!;
        public string? Currency { get; set; }

        public virtual ICollection<TrainingSubscription> TrainingSubscription { get; set; }
    }
}
