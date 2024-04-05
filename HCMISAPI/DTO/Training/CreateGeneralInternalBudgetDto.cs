namespace HCMISAPI.DTO.Training
{
    public class CreateGeneralInternalBudgetDto
    {
        public int? GeneralInternalId { get; set; }
        public int? FinancialYear { get; set; }
        public double? Budget { get; set; }
        public string? Comment { get; set; }
    }
}
