using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IBscPerspectives
    {
        Task<List<ABscPerspectives>> get();

        Task<ABscPerspectives> add(ABscPerspectives entity);

        Task<ABscPerspectives> update(ABscPerspectives entity);  
    }
}
