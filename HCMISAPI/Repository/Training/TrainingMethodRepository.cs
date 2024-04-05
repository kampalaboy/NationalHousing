using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository.Training
{
    public class TrainingMethodRepository : ITrainingMethod
    {
        private HCMISContext _context;

        public TrainingMethodRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingAMethod> add(TrainingAMethod entity)
        {
            _context.Add(entity);
           await  _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TrainingAMethod> get(int id)
        {
            var entity = await _context.TrainingAMethod
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return entity;
        }

        public async Task<IEnumerable<TrainingAMethod>> get(int? id)
        {
            var entities = await _context.TrainingAMethod
               .Where(x => x.Id.Equals(id) || id == null)
               .ToListAsync();

            return entities;
        }

        public async Task<TrainingAMethod> update(TrainingAMethod entity)
        {
            var record = await  _context.TrainingAMethod
                .Where(x => x.Id.Equals(entity.Id))
                .FirstOrDefaultAsync();

            if (record != null)
            {
                record.TrainingMethod = entity.TrainingMethod;
            }

            return entity;
        }
    }
}
