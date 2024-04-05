using Microsoft.EntityFrameworkCore;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;

namespace HCMISAPI.Repository.Training
{
    public class CPDRepository : ICPD
    {
        private readonly HCMISContext _context;

        public CPDRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingCpd> add(TrainingCpd entity)
        {
            _context.TrainingCpd.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public void delete(int id)
        {
            var entity = _context.TrainingCpd
                .Where(x => x.Id == id)
                .FirstOrDefault();
            if (entity != null)
            {
                _context.TrainingCpd.Remove(entity);
                _context.SaveChanges();
            }
        }

        public async Task<TrainingCpd> get(int id)
        {
            var result = await _context.TrainingCpd
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<TrainingCpd>> get(
            DateTime? startDate, DateTime? endDate)
        {
            var results = await _context.TrainingCpd
                .AsNoTracking()
                .Where(x => (x.StartDate >= startDate || startDate == null) &&
                    (x.EndDate <= endDate || endDate == null))
                .ToListAsync();

            return results;
        }

        public async Task<TrainingCpd> update(TrainingCpd entity)
        {
            var training = await _context.TrainingCpd
                .Where(x => x.Id == entity.Id)
                .FirstOrDefaultAsync();

            if(training != null)
            {
                training.Module = entity.Module;
                training.StartDate = entity.StartDate;
                training.EndDate = entity.EndDate;
                training.Location = entity.Location;
                training.Departments = entity.Departments;
                training.Officers = entity.Officers;
                training.Amount = entity.Amount;
                training.Trainer = entity.Trainer;
                await _context.SaveChangesAsync();
            }

            return entity;
        }
    }
}
