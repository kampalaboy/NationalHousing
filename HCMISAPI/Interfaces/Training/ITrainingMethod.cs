using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface ITrainingMethod
    {
        Task<TrainingAMethod> get(int id);

        Task<IEnumerable<TrainingAMethod>> get(int? id);

        Task<TrainingAMethod> add(TrainingAMethod entity);

        Task<TrainingAMethod> update(TrainingAMethod entity);
    }
}
