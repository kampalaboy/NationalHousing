using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BscKpiController : ControllerBase
    {
        private readonly IBscKpi? _context;
        private readonly IMapper? _mapper;

        public BscKpiController(IBscKpi? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
           var entities = await _context.get();

            var _entities = _mapper?.Map<List<ViewBscKpiDto>>(entities);
            return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(ABscKpi entity)
        {
            await _context.add(entity);

            var _entity = _mapper?.Map<CreateBscKpiDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(ABscKpi entity)
        {
            await _context.update(entity);

            var _entity = _mapper?.Map<UpdateBscKpiDto>(entity);
            return Ok(entity);
        }
    }
}
