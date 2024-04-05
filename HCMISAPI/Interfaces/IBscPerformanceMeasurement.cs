using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IBscPerformanceMeasurement
    {
        Task<List<ABscPerformanceMeasurement>> get ();

        Task<ABscPerformanceMeasurement> add (ABscPerformanceMeasurement entity);

        Task<ABscPerformanceMeasurement> update (ABscPerformanceMeasurement entity);
    }
}
