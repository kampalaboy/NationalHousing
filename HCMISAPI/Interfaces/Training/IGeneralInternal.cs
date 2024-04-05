using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface IGeneralInternal
    {
        Task<TrainingGeneralInternal> get(int id);

        Task<IEnumerable<TrainingGeneralInternal>> get(DateTime? startDate, DateTime? endDate);

        Task<TrainingGeneralInternal> add(TrainingGeneralInternal entity);

        Task<TrainingGeneralInternal> update(TrainingGeneralInternal entity);

        void delete(int id);
    }
}
