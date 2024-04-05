using HCMISAPI.Interfaces.Utilities;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository.Utilities
{
    public class FinancialYearRepository : IFinancialYear
    {
        private HCMISContext _context;

        public FinancialYearRepository(HCMISContext context)
        {
            _context = context;
        }
        public async Task<AFinancialYear> add(AFinancialYear entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<AFinancialYear>> get(int? id)
        {
            var entities = await _context.AFinancialYear
               .Where(x => x.Id.Equals(id) || id == null)
               .ToListAsync();

            return entities;
        }

        public async Task<AFinancialYear> update(AFinancialYear entity)
        {
            var record = _context.AFinancialYear
                .FirstOrDefault(x => x.Id == entity.Id);

            if (record == null)
            {
                record = entity;
                _context.Update(record);
                await _context.SaveChangesAsync();

            }

            return record;
        }

    }
}
