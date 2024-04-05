using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{
    public class EmployeeEvidenceRepository : IEmployeeEvidence
    {
        private readonly HCMISContext _context;

        public EmployeeEvidenceRepository(HCMISContext context)
        {
            _context = context;
        }

        public async Task<List<AEmployeeEvidence>> get()
        {
            var entities = await _context.AEmployeeEvidence
                .AsNoTracking()
                .ToListAsync();
                 
            return (entities);
        }

        public async Task<AEmployeeEvidence> add(AEmployeeEvidence entity)
        {
            _context.Add<AEmployeeEvidence>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        public async Task<AEmployeeEvidence?> update(AEmployeeEvidence entity)
        {
            _context.Update<AEmployeeEvidence>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }
    }
}




