using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class BalanceScoreCardBehavioral
    {
        public int BehavioralId { get; set; }
        public int? BalanceScoreCardId { get; set; }
        public int? CompetenceId { get; set; }
        public int? PerformanceDescriptorId { get; set; }
        public double? SupervisorAssessment { get; set; }
        public double? EmployeeSelfAssessment { get; set; }
        public string? EmployeeComment { get; set; }
        public string? SupervisorComment { get; set; }

        public virtual BalanceScoreCard? BalanceScoreCard { get; set; }
        public virtual ABehavioralCompetencies? Competence { get; set; }
        public virtual APerformanceDescriptor? PerformanceDescriptor { get; set; }
    }
}
