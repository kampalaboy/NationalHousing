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
    public class ProfessionalAssociationController : Controller
    {
        private IProfessionalAssociation _context;
        private readonly IMapper _mapper;

        public ProfessionalAssociationController(IProfessionalAssociation context,
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
               .Map<IEnumerable<ViewProfessionalAssociationDto>>(_results);

            return Ok(results);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(
            [FromBody] TrainingAProfessionalAssociation entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }
            //var _patient = _mapper.Map<SadrrPatient>(patient);
            var record = await _context.add(entity);
            //var createdPatient = _mapper.Map<PatientDto>(record);
            return Ok();// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(
            [FromBody] TrainingAProfessionalAssociation entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }
            //var _patient = _mapper.Map<SadrrPatient>(patient);
            var record = await _context.add(entity);
            //var createdPatient = _mapper.Map<PatientDto>(record);
            return Ok();// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }
    }
}
