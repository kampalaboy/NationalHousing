using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface ITargetTeam
    {
        Task<TrainingATargetTeam> get (int id);

        Task<IEnumerable<TrainingATargetTeam>> get (int? id);

        Task<TrainingATargetTeam> add (TrainingATargetTeam entity);

        Task<TrainingATargetTeam> update (TrainingATargetTeam entity);
    }
}
