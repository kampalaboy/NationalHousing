using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IPerformanceDescriptor
    {
        Task<List<APerformanceDescriptor>> get();

        Task<APerformanceDescriptor> add(APerformanceDescriptor entity);

        Task<APerformanceDescriptor> update(APerformanceDescriptor entity);
    }
}
