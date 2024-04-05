namespace HCMISAPI.DTO.Training
{
    public class ViewGeneralInternalBudgetDto
    {
        public int Id { get; set; }
        public int? GeneralInternalId { get; set; }
        public int? FinancialYear { get; set; }
        public double? Budget { get; set; }
        public string? Comment { get; set; }
    }
}
