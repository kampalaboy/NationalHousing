using HCMISAPI.Models;

namespace HCMISAPI.Interfaces
{
    public interface IBehavioralCompentencies
    {
        Task<List<ABehavioralCompetencies>> get ();

        Task<ABehavioralCompetencies> add (ABehavioralCompetencies entity);

        Task<ABehavioralCompetencies> update (ABehavioralCompetencies entity);
    }
}
