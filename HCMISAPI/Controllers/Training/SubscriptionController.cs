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
    public class SubscriptionController : Controller
    {
        private readonly ISubscription _context;
        private readonly IMapper _mapper;

        public SubscriptionController(ISubscription context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ResponseType(typeof(ViewSubscriptionDto))]
        public async Task<IActionResult> Get()
        {
            var _results = await _context
                .get(null, null);

            var results = _mapper
                .Map<IEnumerable<ViewSubscriptionDto>>(_results);

            return Ok(results);
        }

        [HttpGet]
		[Route("{trainingId}")]
        [ResponseType(typeof(ViewSubscriptionDto))]
        public async Task<IActionResult> Get(int trainingId)
        {
            var _results = await _context
                .get(trainingId);

            var results = _mapper
                .Map<ViewSubscriptionDto>(_results);

            return Ok(results);
        }

        [HttpPost]
		[Route("add")]
        [ResponseType(typeof(ViewSubscriptionDto))]
        public async Task<IActionResult> Create(
            [FromBody] CreateSubscriptionDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var _record = _mapper.Map<TrainingSubscription>(entity);
            var record = await _context.add(_record);
            var createdRecord = _mapper.Map<ViewSubscriptionDto>(record);
            return Ok(createdRecord);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }

        [HttpPut]
		[Route("update")]
        [ResponseType(typeof(ViewSubscriptionDto))]
        public async Task<IActionResult> Update(
            [FromBody] UpdateSubscriptionDto entity)
        {
            if (entity == null)
            {
                return BadRequest("Object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid object");
            }

            var _record = _mapper.Map<TrainingSubscription>(entity);
            var record = await _context.update(_record);
            var updatedRecord = _mapper.Map<ViewSubscriptionDto>(record);
            return Ok(updatedRecord);// CreatedAtRoute("GetPatientById", new { id = createdPatient.PatientId }, createdPatient);
        }
    }
}
