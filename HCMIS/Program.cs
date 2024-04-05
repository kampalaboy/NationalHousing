using HCMIS;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
using HCMIS.Model;
using Microsoft.Extensions.DependencyInjection;
using Blazor.SubtleCrypto;
using static HCMIS.Pages.NonStaff.NonStaffQualificationPage;
using HCMIS.ViewModel;
using Blazored.Toast;
using static HCMIS.Pages.NonStaff.NonStaffWorkExperiencePage;
using static HCMIS.Pages.NonStaff.NonStaffSkillsPage;
using static HCMIS.Pages.NonStaff.NonStaffNextOfKinPage;
using static HCMIS.Pages.NonStaff.NonStaffLanguagesKnownPage;
using static HCMIS.Pages.HR.JobTitlePage;
using static HCMIS.Pages.HR.ADepartmentPage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton(builder.Configuration.GetSection("ApiConfig").Get<ApiConfig>());
builder.Services.AddScoped<AppState>();
builder.Services.AddScoped<SystemSettings>();
builder.Services.AddSubtleCrypto(opt =>
    opt.Key = builder.Configuration.GetSection("EncreptionKeys")["secretkey"] //Use another key
);
builder.Services.AddScoped<encrypt_decrypt_string>();
builder.Services.AddScoped<DocumentUploadModel>();
builder.Services.AddScoped<NonStaffQualificationAdapter>();
builder.Services.AddScoped<NonStaffWorkExperienceAdapter>();
builder.Services.AddScoped<NonStaffSkillsAdapter>();
builder.Services.AddScoped<NonStaffNextOfKinAdapter>();
builder.Services.AddScoped<NonStaffLanguagesKnownAdapter>();
builder.Services.AddScoped<AJobTitleAdapter>();
builder.Services.AddScoped<ADepartmentAdapter>();
builder.Services.AddScoped(sp => 
    new HttpClient 
    { 
        BaseAddress = new Uri("https://localhost:7188/api/")
    });
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njc5MTQ3QDMyMzAyZTMyMmUzMEVuTUJNL2NmWFMyZnNaWHZQb051djNVZzlxTEcxNmh4NlhXbWYyQVZXUGM9");
await builder.Build().RunAsync();
