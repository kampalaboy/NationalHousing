using AutoMapper;
using HCMISAPI.DTO;
using HCMISAPI.Interfaces;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceDescriptorController : ControllerBase
    {
        private readonly IPerformanceDescriptor? _context;
        private readonly IMapper? _mapper;

        public PerformanceDescriptorController(IPerformanceDescriptor? context, IMapper? mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> get()
        {
            var entities = await _context.get();

            var _entities = _mapper.Map<List<ViewPerformanceDescriptorDto>> (entities);
            return Ok (_entities);
        }

        [HttpPost]
        public async Task<IActionResult> create(APerformanceDescriptor entity)
        {
            _context.add(entity);

            var _entity = _mapper.Map<CreatePerfomanceDescriptorDto>(entity);
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> update(APerformanceDescriptor entity)
        {
            _context?.update(entity);

            var _entity = _mapper?.Map<UpdatePerformanceDescriptorDto>(entity);
            return Ok(entity);
        }
    }

}
