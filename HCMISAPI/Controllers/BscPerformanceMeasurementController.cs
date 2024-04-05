using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BscPerformanceMeasurementController : ControllerBase
    {
        private readonly IBscPerformanceMeasurement? _context;
        private readonly IMapper? _mapper;

        public BscPerformanceMeasurementController(IBscPerformanceMeasurement? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
           var entities = await _context.get();

           var _entities = _mapper?.Map<List<ViewBscPerformanceMeasurementDto>>(entities);
            return Ok(_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(ABscPerformanceMeasurement entity)
        {
            await _context.add(entity);

            var _entity = _mapper?.Map<CreateBscPerformanceMeasurementDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(ABscPerformanceMeasurement entity)
        {
            await _context.update(entity);

            var _entity = _mapper?.Map<UpdateBscPerformanceMeasurementDto>(entity);
            return Ok(entity);
        }
    }
}
