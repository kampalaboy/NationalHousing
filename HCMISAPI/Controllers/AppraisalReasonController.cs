using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppraisalReasonController : ControllerBase
    {
        private readonly IAppraisalReason? _context;
        private readonly IMapper? _mapper;

        public AppraisalReasonController(IAppraisalReason context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            var entities = await _context.get();

            var _entities = _mapper.Map<List<ViewAppraisalReasonDto>>(entities);
                return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(AAppraisalReason entity)
        {
           var result = _context.add(entity);

            var _result = _mapper.Map<CreateAppraisalReasonDto>(result);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> update(AAppraisalReason entity)
        {
            var result = _context.update(entity);

            var _result = _mapper.Map<UpdateAppraisalReasonDto>(result);

            return Ok(result);

        }
    }
}
