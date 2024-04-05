using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class BehavioralCompetenciesRepository : IBehavioralCompentencies
    {
        private readonly HCMISContext _context;

        public BehavioralCompetenciesRepository(HCMISContext context)
        {
            _context = context;
        }


        public async Task<List<ABehavioralCompetencies>> get()
        {
            var entities = await _context.ABehavioralCompetencies
                 .AsNoTracking()
                 .ToListAsync();
            return (entities);
        }

        public async Task<ABehavioralCompetencies> add(ABehavioralCompetencies entity)
        {
            _context.Add<ABehavioralCompetencies>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }



        public async Task<ABehavioralCompetencies?> update(ABehavioralCompetencies entity)
        {
            _context.Update<ABehavioralCompetencies>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}