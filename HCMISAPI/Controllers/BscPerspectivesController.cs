using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BscPerspectivesController : ControllerBase
    {
        private readonly IBscPerspectives? _context;
        private readonly IMapper? _mapper;

        public BscPerspectivesController(IBscPerspectives? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            var entities = await _context.get();

            var _entities = _mapper?.Map<List<ViewBscPerspectivesDto>>(entities);
            return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(ABscPerspectives entity)
        {
            await _context.add(entity);

            var _entity = _mapper?.Map<CreateBscPerspectivesDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(ABscPerspectives entity)
        {
            await _context.update(entity);

            var _entity = _mapper?.Map<UpdateBscPerspectivesDto>(entity);
            return Ok(entity);
        }
    }
}
