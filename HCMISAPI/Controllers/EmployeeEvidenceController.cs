using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEvidenceController : ControllerBase
    {
        private readonly IEmployeeEvidence? _context;
        private readonly IMapper? _mapper;

        public EmployeeEvidenceController(IEmployeeEvidence? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            var entities = await _context.get();

            var _entities = _mapper?.Map<List<ViewEmployeeEvidenceDto>>(entities);
            return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(AEmployeeEvidence entity)
        {
            await _context.add(entity);

            var _entity = _mapper?.Map<CreateEmployeeEvidenceDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(AEmployeeEvidence entity)
        {
            await _context.update(entity);

            var _entity = _mapper?.Map<UpdateEmployeeEvidenceDto>(entity);
            return Ok(entity);
        }
    }
}

