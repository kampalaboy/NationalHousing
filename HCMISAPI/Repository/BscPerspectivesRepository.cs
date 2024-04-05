using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class BscPerspectivesRepository : IBscPerspectives
    {
        private readonly HCMISContext _context;

        public BscPerspectivesRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<List<ABscPerspectives>> get()
        {
            var entities = await _context.ABscPerspectives
                .AsNoTracking()
                .ToListAsync();
                 
            return (entities);
        }

        public async Task<ABscPerspectives> add(ABscPerspectives entity)
        {
            _context.Add<ABscPerspectives>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        public async Task<ABscPerspectives?> update(ABscPerspectives entity)
        {
            _context.Update<ABscPerspectives>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}




