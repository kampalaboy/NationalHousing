using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HCMISAPI.Interfaces.Utilities;
using HCMISAPI.Models;
using HCMISAPI.DTO.Utilities;
using System.Web.Http.Description;

namespace HCMISAPI.Controllers.Utilities
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrency _context;
        private readonly IMapper _mapper;

        public CurrencyController(ICurrency context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(string? id = null)
        {
            var _results = await _context
                .get(id);

            var results = _mapper
               .Map<IEnumerable<ViewCurrencyDto>>(_results);

            return Ok(results);
        }

        [HttpPost ("add")]
        public async Task<IActionResult> Create(
            [FromBody] ACurrency entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var record = await _context.add(entity);
            return Ok(record);
        }

        [HttpPut ("update")]
        public async Task<IActionResult> Update(
            [FromBody] ACurrency entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var record = await _context.update(entity);
            return Ok(record);
        }




    }
}
