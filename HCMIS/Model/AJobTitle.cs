namespace HCMIS.Model
{
    public class AJobTitle
    {
        public int JobTitleId { get; set; }
        public int? DepartmentId { get; set; }
        public string? JobTitleDescription { get; set; }
        public string? ReportsTo { get; set; }
    }
}
