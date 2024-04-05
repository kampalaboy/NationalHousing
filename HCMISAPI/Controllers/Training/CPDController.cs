using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HCMISAPI.Interfaces.Training;
using HCMISAPI.Models;
using HCMISAPI.DTO.Training;
using System.Web.Http.Description;


namespace HCMISAPI.Controllers.Training
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPDController : ControllerBase
    {
        private readonly ICPD _context;
        private readonly IMapper _mapper;

        public CPDController(ICPD context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(ViewCpdDto))]
        public async Task<IActionResult> Get()
        {
            var results = await _context
                .get(null, null);

            if(results == null)
            {
                return NoContent();
            }

            IEnumerable<ViewCpdDto> entities = _mapper
                .Map<IEnumerable<ViewCpdDto>>(results);

            return Ok(entities);
        }

        [HttpGet]
        [Route("{Id}")]
        [ResponseType(typeof(ViewCpdDto))]
        public async Task<IActionResult> Get(int Id)
        {
            var _entity = await _context
                .get(Id);

            ViewCpdDto entity =  _mapper.Map<ViewCpdDto>(_entity);

            return Ok(entity);
        }

        [HttpPost]
        [Route(("add"))]
        [ResponseType(typeof(ViewCpdDto))]
        public async Task<IActionResult> Create(
            [FromBody] CreateCpdDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }
            var _record = _mapper.Map<TrainingCpd>(entity);
            var record = await _context.add(_record);
            var createdPatient = _mapper.Map<ViewCpdDto>(record);
            return Ok(createdPatient);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }

        [HttpPut]
        [Route("update")]
        [ResponseType(typeof(ViewCpdDto))]
        public async Task<IActionResult> Update(
            [FromBody] UpdateCpdDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Training object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var _record = _mapper.Map<TrainingCpd>(entity);
            var record = await _context.update(_record);
            var updatedRecord = _mapper.Map<ViewCpdDto>(record);
            return Ok(updatedRecord);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }
    }
}
