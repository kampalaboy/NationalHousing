using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Utilities
{
    public interface IFinancialYear
    {
        Task<IEnumerable<AFinancialYear>> get(int? id);

        Task<AFinancialYear> add(AFinancialYear entity);

        Task<AFinancialYear> update(AFinancialYear entity);
    }
}
