using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Repository
{


    public class AppraisialReasonRepository : IAppraisalReason
    {
        private readonly HCMISContext _context;
        
        public AppraisialReasonRepository (HCMISContext context)
            {
              _context = context;
            }
        

        public async Task<List<AAppraisalReason>> get()
        {
            var entities = await _context.AAppraisalReason
                .AsNoTracking()
                .ToListAsync();
                 
            return (entities);
        }

        public async Task<AAppraisalReason?> add(AAppraisalReason entity)
        {
             _context.Add<AAppraisalReason>(entity);
            await _context.SaveChangesAsync();

            return (entity);
        }

        

        public async Task<AAppraisalReason?> update(AAppraisalReason entity)
        {
            _context.Update<AAppraisalReason>(entity);
            await _context.SaveChangesAsync();

            return(entity);
        }
    }
}
