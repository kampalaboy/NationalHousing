using HCMISAPI.Models;

namespace HCMISAPI.Interfaces.Training
{
    public interface ICPD
    {
        Task<TrainingCpd> get(int id);

        Task<IEnumerable<TrainingCpd>> get(DateTime? startDate, DateTime? endDate);

        Task<TrainingCpd> add(TrainingCpd entity);

        Task<TrainingCpd> update(TrainingCpd entity);

        void delete(int entity);
    }
}
