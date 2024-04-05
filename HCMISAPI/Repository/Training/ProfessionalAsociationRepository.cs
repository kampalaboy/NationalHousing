using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository.Training
{
    public class ProfessionalAsociationRepository : IProfessionalAssociation
    {
        private HCMISContext _context;

        public ProfessionalAsociationRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<TrainingAProfessionalAssociation> 
            add(TrainingAProfessionalAssociation entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<TrainingAProfessionalAssociation>> get(int? id)
        {
            var entities = await _context.TrainingAProfessionalAssociation
                .Where(x => x.Id.Equals(id) || id == null)
                .ToListAsync();

            return entities;
        }

        public async Task<TrainingAProfessionalAssociation> 
            update(TrainingAProfessionalAssociation entity)
        {
            var record = await _context.TrainingAProfessionalAssociation
                .Where(x => x.Id.Equals(entity.Id))
                .FirstOrDefaultAsync();

            if(record != null)
            {
                record.ProfessionalAssociation = entity.ProfessionalAssociation;
            }

            return entity;
        }
    }
}
