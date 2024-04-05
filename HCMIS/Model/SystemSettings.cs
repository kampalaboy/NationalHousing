using Blazored.LocalStorage;

namespace HCMIS.Model
{
    public class SystemSettings
    {


        const string _AccessToken = "AccessToken";
        const string _UserRole = "UserRole";
        const string _Username = "Username";
        const string _Password = "Password";
        const string _ExpiryDate = "ExpiryDate";

        public string? AccessToken { get; set; }
        public string? UserRole { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public string? AccountHolderName { get; set; }
        public int StaffId { get; set; }

        ILocalStorageService localStore;
        encrypt_decrypt_string decrpt;
        public SystemSettings(ILocalStorageService _localStore,
           encrypt_decrypt_string _decrpt)
        {
            localStore = _localStore;
            decrpt = _decrpt;
        }

        public async Task GetLoginCredentials()
        {
            string credentials = await localStore.GetItemAsync<string>("Credentials");
            if (credentials != null)
            {
                SystemCredentials m = await decrpt.DecryptCredentials(credentials);
                if(m != null)
                {
                    AccessToken = m.AccessToken;
                    ExpiryDate = m.ExpiryDate;
                    UserRole = m.UserRole;
                    Username = m.Username;
                    Password = m.Password;
                    AccountHolderName=m.AccountHolderName;
                    StaffId = m.StaffId;
                }
                else
                {
                    AccessToken = null;
                    ExpiryDate = null;
                    UserRole = null;
                    Username = null;
                    Password = null;
                    AccountHolderName = null;
                    StaffId = 0;
                }
            }
            else
            {
                AccessToken = null;
                ExpiryDate = null;
                   UserRole = null;
                Username = null;
                Password = null;
                AccountHolderName = null;
                StaffId =0;
            }
        }
    }
}
