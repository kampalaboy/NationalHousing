namespace HCMIS.Model
{
    public class SystemCredentials
    {
        public string? AccessToken { get; set; }
        public string? UserRole { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string AccountHolderName { get; set; }
        public int StaffId { get; set; }
    }
}
