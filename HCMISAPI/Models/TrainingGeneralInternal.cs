using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class TrainingGeneralInternal
    {
        public TrainingGeneralInternal()
        {
            TrainingGeneralInternalBudget = new HashSet<TrainingGeneralInternalBudget>();
        }

        public int Id { get; set; }
        public string? TrainingDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TrainingMethod { get; set; }
        public string? TargetTeam { get; set; }
        public string? ExpectedOutcomes { get; set; }

        public virtual ICollection<TrainingGeneralInternalBudget> TrainingGeneralInternalBudget { get; set; }
    }
}
