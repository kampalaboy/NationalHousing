using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IBscKpi
    {
        Task<List<ABscKpi>> get ();

        Task<ABscKpi> add (ABscKpi entity);

        Task<ABscKpi> update(ABscKpi entity);
    }
}
