using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AFinancialYear
    {
        public AFinancialYear()
        {
            TrainingGeneralInternalBudget = new HashSet<TrainingGeneralInternalBudget>();
        }

        public int Id { get; set; }
        public string? FinancialYear { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TrainingGeneralInternalBudget> TrainingGeneralInternalBudget { get; set; }
    }
}
