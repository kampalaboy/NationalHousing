using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Utilities
{
    public interface ICurrency
    {
        Task<IEnumerable<ACurrency>> get(string? id);

        Task<ACurrency> add(ACurrency entity);

        Task<ACurrency> update(ACurrency entity);
    }
}
