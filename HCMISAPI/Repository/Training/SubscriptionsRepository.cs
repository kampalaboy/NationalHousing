using Microsoft.EntityFrameworkCore;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;

namespace HCMISAPI.Repository.Training
{
    public class SubscriptionsRepository : ISubscription
    {
        private HCMISContext _context;

        public SubscriptionsRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingSubscription> add(TrainingSubscription entity)
        {
           _context.Add(entity);
           await _context.SaveChangesAsync();
           return entity;
        }

        public async void delete(int id)
        {
            var entity = await _context.TrainingSubscription
                .Where(x => x.Equals(id))
                .FirstOrDefaultAsync();

            if(entity!= null)
            {
                _context.Remove(entity);
                _context.SaveChanges(); 
            }
        }

        public  async Task<TrainingSubscription> get(int id)
        {
            var entity = await _context.TrainingSubscription
                .Where(x => x.Id.Equals(id))
                .FirstOrDefaultAsync();

            return entity;
        }

        public async Task<IEnumerable<TrainingSubscription>> 
            get(DateTime? startDate, DateTime? endDate)
        {
            var results = await _context.TrainingSubscription
                .AsNoTracking()
                .Where(x => (x.StartDate == startDate || startDate == null) &&
                    (x.EndDate == endDate || endDate == null))
                .ToListAsync();

            return results;
        }

        public async Task<TrainingSubscription> update(TrainingSubscription entity)
        {
            var training = await _context.TrainingSubscription
                .Where(x => x.Id.Equals(entity.Id))
                .FirstOrDefaultAsync();

            if (training != null)
            {
                training.EmployeeId = entity.EmployeeId;
                training.StartDate = entity.StartDate;
                training.EndDate = entity.EndDate;
                training.CourseDetails = entity.CourseDetails;
                training.ProfessionalAssociation = entity.ProfessionalAssociation;
                training.Currency = entity.Currency;
                training.AmountPaid = entity.AmountPaid;

                _context.TrainingSubscription.Update(training);
                _context.SaveChanges();
            }

            return entity;
        }
    }
}
