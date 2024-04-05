﻿namespace HCMIS.DTOs.Training
{
	public class UpdateGeneralInternalDto
	{
        public int Id { get; set; }
        public string? TrainingDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? TrainingMethod { get; set; }
        public string? TargetTeam { get; set; }
        public string? ExpectedOutcomes { get; set; }

        public virtual ICollection<ViewGeneralInternalBudgetDto>? TrainingGeneralInternalBudget { get; set; }

    }
}
