using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class BscKpiRepository : IBscKpi
    {
        private readonly HCMISContext _context;

        public BscKpiRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<List<ABscKpi>> get()
        {
            var entities = await _context.ABscKpi
                 .AsNoTracking()
                 .ToListAsync();

            return (entities);
        }

        public async Task<ABscKpi> add(ABscKpi entity)
        {
            _context.Add<ABscKpi>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        public async Task<ABscKpi?> update(ABscKpi entity)
        {
            _context.Update<ABscKpi>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}
