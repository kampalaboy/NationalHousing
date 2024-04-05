using HCMISAPI.Interfaces.Utilities;
using HCMISAPI.Repository.Utilities;

namespace HCMISAPI.Extensions
{
    public static class UtilityExtensions
    {
        public static void ConfigureUtilityRepository(this
        IServiceCollection services)
        {
            services.AddScoped<ICurrency, CurrencyRepository>();

            services.AddScoped<IFinancialYear, FinancialYearRepository>();
        }
    }
}
