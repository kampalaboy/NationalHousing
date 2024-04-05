using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class TrainingAProfessionalAssociation
    {
        public TrainingAProfessionalAssociation()
        {
            TrainingSubscription = new HashSet<TrainingSubscription>();
        }

        public int Id { get; set; }
        public string? ProfessionalAssociation { get; set; }

        public virtual ICollection<TrainingSubscription> TrainingSubscription { get; set; }
    }
}
