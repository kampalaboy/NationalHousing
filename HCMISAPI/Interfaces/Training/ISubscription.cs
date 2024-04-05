using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface ISubscription
    {
        Task<TrainingSubscription> get(int id);

        Task<IEnumerable<TrainingSubscription>> get(DateTime? startDate, DateTime? endDate);

        Task<TrainingSubscription> add(TrainingSubscription entity);

        Task<TrainingSubscription> update(TrainingSubscription entity);

        void delete(int id);
    }
}
