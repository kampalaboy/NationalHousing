using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using System.Web.Http.Description;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.Controllers.Training
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetTeamController : ControllerBase
    {
        private readonly ITargetTeam _context;
        private readonly IMapper _mapper;

        public TargetTeamController(ITargetTeam context,
            IMapper mapper)
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
               .Map<IEnumerable<ViewTargetTeamDto>>(_results);

            return Ok(_results);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(
            [FromBody] CreateTargetTeamDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Object");
            }

            //var _record = await _context.add(entity);

            var record =  _mapper.Map<CreateTargetTeamDto>(entity);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(
            [FromBody] TrainingATargetTeam entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Object");
            }

           var record = await _context.update(entity);
            return Ok();
        }

    }
}
