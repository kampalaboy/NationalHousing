using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class TrainingGeneralInternalBudget
    {
        public int Id { get; set; }
        public int? GeneralInternalId { get; set; }
        public int? FinancialYear { get; set; }
        public double? Budget { get; set; }
        public string? Comment { get; set; }

        public virtual AFinancialYear? FinancialYearNavigation { get; set; }
        public virtual TrainingGeneralInternal? GeneralInternal { get; set; }
    }
}
