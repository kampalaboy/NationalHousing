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
    public class GeneralInternalController : Controller
    {
        private readonly IGeneralInternal _context;
        private readonly IMapper _mapper;

        public GeneralInternalController(IGeneralInternal context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
		[Route("")]
        [ResponseType(typeof(ViewGeneralInternalDto))]
        public async Task<IActionResult> Get()
        {
            var _results = await _context
                .get(null, null);

            var results = _mapper
                .Map<IEnumerable<ViewGeneralInternalDto>>(_results);

            return Ok(_results);
        }

        [HttpGet]
		[Route("{id}")]
        [ResponseType(typeof(ViewGeneralInternalDto))]
        public async Task<IActionResult> Get(int id)
        {
            var _result = await _context
                .get(id);

            var result = _mapper
                .Map<ViewGeneralInternalDto>(_result);

            return Ok(result);
        }

        [HttpPost]
		[Route("add")]
        [ResponseType(typeof(UpdateGeneralInternalDto))]
        public async Task<IActionResult> Create(
            [FromBody] CreateGeneralInternalDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }
            var _result = _mapper.Map<TrainingGeneralInternal>(entity);
            var record = await _context.add(_result);
            var createdRecord = _mapper.Map<UpdateGeneralInternalDto>(record);
            return Ok(createdRecord);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }

        [HttpPut]
		[Route("update")]
        [ResponseType(typeof(UpdateGeneralInternalDto))]
        public async Task<IActionResult> Update(
            [FromBody] UpdateGeneralInternalDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }
            var _result = _mapper.Map<TrainingGeneralInternal>(entity);
            var record = await _context.update(_result);
            var createdRecord = _mapper.Map<UpdateGeneralInternalDto>(record);
            return Ok(createdRecord);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }
    }
}
