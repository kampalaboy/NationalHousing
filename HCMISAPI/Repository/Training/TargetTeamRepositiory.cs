using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository.Training
{
    public class TargetTeamRepositiory : ITargetTeam
    {
        private HCMISContext _context;

        public TargetTeamRepositiory(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingATargetTeam> add(TrainingATargetTeam entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TrainingATargetTeam> get(int id)
        {
            var entities = await _context.TrainingATargetTeam
               .Where(x => x.Id.Equals(id))
               .FirstOrDefaultAsync();


            return entities;
        }

        public async Task<IEnumerable<TrainingATargetTeam>> get(int? id)
        {
            var entities = await _context.TrainingATargetTeam
               .Where(x => x.Id.Equals(id) || id == null)
               .ToListAsync();

            return entities;
        }

        public async Task<TrainingATargetTeam> update(TrainingATargetTeam entity)
        {
            var record =  await _context.TrainingATargetTeam
                .Where(x => x.Id.Equals(entity.Id))
                .FirstOrDefaultAsync();

            if (record != null)
            {
                record.TargetTeam = entity.TargetTeam;
                _context.Update(record);
                await _context.SaveChangesAsync();
            }

            return entity;
        }
    }
}
