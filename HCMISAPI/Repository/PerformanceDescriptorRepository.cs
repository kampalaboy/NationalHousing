using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class PerformanceDescriptorRepository : IPerformanceDescriptor
    {
        private readonly HCMISContext _context;

        public PerformanceDescriptorRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<List<APerformanceDescriptor>> get()
        {
            var entities = await _context.APerformanceDescriptor
                 .AsNoTracking()
                 .ToListAsync();    

            return (entities);
        }

        public async Task<APerformanceDescriptor> add(APerformanceDescriptor entity)
        {
            _context.Add<APerformanceDescriptor>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        public async Task<APerformanceDescriptor?> update(APerformanceDescriptor entity)
        {
            _context.Update<APerformanceDescriptor>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}




