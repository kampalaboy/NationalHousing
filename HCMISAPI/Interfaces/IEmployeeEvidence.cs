using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IEmployeeEvidence
    {
        Task<List<AEmployeeEvidence>> get();

        Task<AEmployeeEvidence> add(AEmployeeEvidence entity);

        Task<AEmployeeEvidence> update(AEmployeeEvidence entity);
    }
}
