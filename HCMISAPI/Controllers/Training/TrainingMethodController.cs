using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using HCMISAPI.DTO;
using System.Web.Http.Description;
using HCMISAPI.DTO.Training;

namespace HCMISAPI.Controllers.Training
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingMethodController : ControllerBase
    {
        private readonly ITrainingMethod _context;
        private readonly IMapper _mapper;

        public TrainingMethodController(ITrainingMethod context,
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
               .Map<IEnumerable<ViewTrainingMethodDto>>(_results);

            return Ok(results);
        }
        [HttpPost ("update")]
        public async Task<IActionResult> Update(
            [FromBody] TrainingAMethod entity)
        {
            if (entity == null)
            { 
                return BadRequest("Object is null");
            
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var _record = await _context.update(entity);

            var record = _mapper.Map<ViewTrainingMethodDto>(_record);

            return Ok(entity);
        }


    }
}
