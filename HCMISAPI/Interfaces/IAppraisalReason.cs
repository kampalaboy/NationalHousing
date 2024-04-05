using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IAppraisalReason
    {
        Task<List<AAppraisalReason>> get();

         Task<AAppraisalReason?> add(AAppraisalReason entity);

         Task<AAppraisalReason?> update(AAppraisalReason entity);
    }
}
