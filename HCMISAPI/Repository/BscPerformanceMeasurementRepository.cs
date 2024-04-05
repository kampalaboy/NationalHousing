using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class BscPerformanceMeasurementRepository : IBscPerformanceMeasurement
    {
        private readonly HCMISContext _context;

        public BscPerformanceMeasurementRepository (HCMISContext context)
        {
            _context = context;
        }

        public async Task<List<ABscPerformanceMeasurement>> get()
        {
            var entities = await _context.ABscPerformanceMeasurement
                .AsNoTracking()
                .ToListAsync();
                 
            return (entities);
        }

        public async Task<ABscPerformanceMeasurement> add(ABscPerformanceMeasurement entity)
        {
            _context.Add<ABscPerformanceMeasurement>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        public async Task<ABscPerformanceMeasurement?> update(ABscPerformanceMeasurement entity)
        {
            _context.Update<ABscPerformanceMeasurement>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}

