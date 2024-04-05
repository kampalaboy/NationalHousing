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
    public class FinancialYearController : ControllerBase
    {
        private IFinancialYear _context;
        private readonly IMapper _mapper;

        public FinancialYearController(IFinancialYear context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> Get(int? id = null)
        {
            var _results = await _context
                .get(id);

            var results = _mapper
               .Map<IEnumerable<ViewFinancialYearDto>>(_results);

            return Ok(results);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(
            [FromBody] AFinancialYear entity)
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
            [FromBody] AFinancialYear entity)
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
