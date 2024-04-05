using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehavioralCompetenciesController : ControllerBase
    {
        private readonly IBehavioralCompentencies? _context;
        private readonly IMapper? _mapper;

        public BehavioralCompetenciesController(IBehavioralCompentencies? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
           var entities = await _context.get();

            var _entities = _mapper?.Map<List<ViewBehavioralCompetenciesDto>>(entities);
            return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(ABehavioralCompetencies entity)
        {
            await _context.add(entity);

            var _entity = _mapper?.Map<CreateBehavioralCompetenciesDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(ABehavioralCompetencies entity)
        {
            await _context.update(entity);

            var _entity = _mapper?.Map<UpdateBehavioralCompetenciesDto>(entity);
            return Ok(entity);
        }
    }
}
