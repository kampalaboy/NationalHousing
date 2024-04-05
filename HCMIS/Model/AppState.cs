using Blazored.LocalStorage;

namespace HCMIS.Model
{
    public class AppState
    {
        ILocalStorageService localStore;
        public AppState(ILocalStorageService _localStore)
        {
            localStore= _localStore;
        }
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

        private bool _loggedIn;
        public event Action OnChange;
        public bool LoggedIn
        {
            get { return _loggedIn; }
            set
            {
                if (_loggedIn != value)
                {
                    _loggedIn = value;
                    if (value)
                    {
                        GetLoginCredentials();
                    }
                    else
                    {
                        ClearCredentials();
                    }
                }
            }
        }

        private void ClearCredentials()
        {
            AccessToken = null;
            UserRole = null;
            Username = null;
            Password = null;
            ExpiryDate = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        private async void GetLoginCredentials()
        {
            AccessToken = await localStore.GetItemAsync<string>(_AccessToken);
            ExpiryDate = await localStore.GetItemAsync<DateTime>(_ExpiryDate);
            UserRole = await localStore.GetItemAsync<string>(_UserRole);
            Username = await localStore.GetItemAsync<string>(_Username);
            Password = await localStore.GetItemAsync<string>(_Password);

            NotifyStateChanged();
        }
    }
}
