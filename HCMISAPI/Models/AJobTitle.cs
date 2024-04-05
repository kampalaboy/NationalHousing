using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class AJobTitle
    {
        public AJobTitle()
        {
            BalanceScoreCard = new HashSet<BalanceScoreCard>();
            JobDescription = new HashSet<JobDescription>();
        }

        public int JobTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? ReportsTo { get; set; }

        public virtual ADepartment? Department { get; set; }
        public virtual ICollection<BalanceScoreCard> BalanceScoreCard { get; set; }
        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}
