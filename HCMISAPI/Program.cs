using Blazor.SubtleCrypto;
using HCMISAPI.Data;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using HCMISAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.ConfigureCors();
//builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureHCMISContext(builder.Configuration);
builder.Services.ConfigureApplicationDbContext(builder.Configuration);
builder.Services.ConfigureTrainingRepository();
builder.Services.ConfigureUtilityRepository();
builder.Services.AddAutoMapper(typeof(Program));

////For Entity Framework
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<HCMISContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddSubtleCrypto(opt =>
    opt.Key = builder.Configuration.GetSection("EncreptionKeys")["secretkey"] //Use another key
);
builder.Services.AddScoped<encrypt_decrypt_string>();
// For Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HCMISAPI", Version = "v1" });
    c.AddSecurityDefinition("Oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization Header Using the Bearer Scheme(\"bearer{token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey

    });
    c.OperationFilter<SecurityRequirementsOperationFilter>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Shows UseCors with CorsPolicyBuilder.
//app.UseCors(builder =>
//{
//    builder
//    .AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader();
//});

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseCors("CorsPolicy");
// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();



//Scaffold-DbContext "Server=.;Database=NHCCHumanResourceSystem;User Id=sa;password=root85;Trusted_Connection=False;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f -context "HCMISContext" -NoPluralize

//IConfigurationRoot configuration = new ConfigurationBuilder()
//                               .SetBasePath(Directory.GetCurrentDirectory())
//                               .AddJsonFile("appsettings.json")
//                               .Build();
//var connectionString = configuration.GetConnectionString("DefaultConnection");
//optionsBuilder.UseSqlServer(connectionString);


//using Microsoft.Extensions.Configuration;
//using System.IO;


//SPToCore.exe scan -cnn "Data Source=IBS;Initial Catalog=NHCCHumanResourceSystem;Persist Security Info=True;User ID=sa;Password=root85;" -sch * -nsp MUCOBADI -ctx MUCOBADIContext -sf Models -pf D:\Systems\Core\MUCOBADI\Models\ -f SPToCoreContext.cs
