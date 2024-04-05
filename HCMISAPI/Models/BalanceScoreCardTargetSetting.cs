using System;
using System.Collections.Generic;

namespace HCMISAPI.Models
{
    public partial class BalanceScoreCardTargetSetting
    {
        public int TargetSettingId { get; set; }
        public int? BalanceScoreCardId { get; set; }
        public int? BscPerspectiveId { get; set; }
        public int? EmployeeSelfAssessTgt { get; set; }
        public int? SupervisorAssessTgt { get; set; }
        public int? IntProcessPerspEmployeeSelfAssessTgt { get; set; }
        public int? IntProcessPerspSupervisorAssessTgt { get; set; }
        public int? CustomerPerspEmployeeSelfAssessTgt { get; set; }
        public int? CustomerPerspSupervisorAssessTgt { get; set; }
        public int? LearningPerspEmployeeSelfAssessTgt { get; set; }
        public int? LearningPerspSupervisorAssessTgt { get; set; }
        public int? MeasurementMetricId { get; set; }
        public double? PerspectiveTotalWeight { get; set; }
        public int? Bsckpiid { get; set; }
        public double? IndividualTargetWeight { get; set; }
        public int? EvidenceId { get; set; }
        public double? IndividualTargetObjectiveScore { get; set; }
        public string? SupervisorComments { get; set; }

        public virtual BalanceScoreCard? BalanceScoreCard { get; set; }
        public virtual ABscPerspectives? BscPerspective { get; set; }
        public virtual ABscKpi? Bsckpi { get; set; }
        public virtual AEmployeeEvidence? Evidence { get; set; }
        public virtual ABscPerformanceMeasurement? MeasurementMetric { get; set; }
    }
}
