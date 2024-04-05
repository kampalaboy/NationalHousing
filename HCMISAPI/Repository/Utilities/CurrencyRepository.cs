using HCMISAPI.Interfaces.Utilities;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository.Utilities
{
    public class CurrencyRepository : ICurrency
    {
        private HCMISContext _context;

        public CurrencyRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<ACurrency> add(ACurrency entity)
        {
            _context.Add(entity);
           await  _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<ACurrency>> get(string? id)
        {
            var entities = await _context.ACurrency
                .Where(x => x.IsoCode.Equals(id) || string.IsNullOrEmpty(id))
                .ToListAsync();

            return entities;
        }

        public async Task<ACurrency> update(ACurrency entity)
        {
            var record = await _context.ACurrency
                .Where(x => x.IsoCode.Equals(entity.IsoCode))
                .FirstOrDefaultAsync();
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
