using Microsoft.EntityFrameworkCore;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;

namespace HCMISAPI.Repository.Training
{
    public class GeneralInternalRepository : IGeneralInternal
    {
        private HCMISContext _context;

        public GeneralInternalRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingGeneralInternal> add(TrainingGeneralInternal entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async void delete(int id)
        {
            var entity = await _context.TrainingGeneralInternal
                .Where(x => x.Id == id)
                .Include(x => x.TrainingGeneralInternalBudget)
                .FirstOrDefaultAsync();
            if(entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public async Task<TrainingGeneralInternal> get(int id)
        {
            var entity = await _context.TrainingGeneralInternal
                .Where(_context => _context.Id == id)
                .Include(x => x.TrainingGeneralInternalBudget)
                .FirstOrDefaultAsync();

            return entity;

        }

        public async Task<IEnumerable<TrainingGeneralInternal>> 
            get(DateTime? startDate, DateTime? endDate)
        {
            var results = await _context.TrainingGeneralInternal
                .AsNoTracking()
                .Where(x => (x.StartDate == startDate || startDate == null) &&
                    (x.EndDate == endDate || endDate == null))
                //.Include(x => x.TrainingGeneralInternalBudget)
                .ToListAsync();

            return results;
        }

        public async Task<TrainingGeneralInternal> update(TrainingGeneralInternal entity)
        {
            var training = await _context.TrainingGeneralInternal
                .Where(x => x.Id == entity.Id)
                .FirstOrDefaultAsync();

            if(training != null)
            {
                training.TrainingDescription = entity.TrainingDescription;
                training.StartDate = entity.StartDate;
                training.EndDate = entity.EndDate;
                training.TrainingMethod = entity.TrainingMethod;
                training.TargetTeam = entity.TargetTeam;
                training.ExpectedOutcomes = entity.ExpectedOutcomes;
                
                foreach(var detail in entity.TrainingGeneralInternalBudget)
                {
                    var exists = await _context.TrainingGeneralInternalBudget
                        .AsNoTracking()
                        .Where(x => x.Id == detail.Id)
                        .FirstOrDefaultAsync();
                    if (exists == null)
                    {
                        training.TrainingGeneralInternalBudget.Add(detail);
                    }
                }

                training.TrainingGeneralInternalBudget =
                entity.TrainingGeneralInternalBudget;

                _context.TrainingGeneralInternal.Update(training);
                _context.SaveChanges();
            }

            return training;
        }
    }
}
