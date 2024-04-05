using HCMISAPI.Data;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanResourceController : ControllerBase
    {
        private readonly HCMISContext db;
        public HumanResourceController(HCMISContext _db)
        {
            this.db = _db;
        }
        #region Job Title
        [Authorize]
        [HttpGet]
        [Route("GetJobTitle")]
        public async Task<List<AJobTitle>> GetJobTitle()
        {
            List<AJobTitle> m = new List<AJobTitle>();
            var data = await db.AJobTitle.ToListAsync();
            if(data == null)
            {
                return m;
            }

            return data;
        }

        [Authorize]
        [HttpPut]
        [Route("PutJobTitle")]
        public async Task<IActionResult> UpdateJobTitle(AJobTitle JobTitle)
        {
            if (JobTitle.JobTitleId > 0)
            {
                try
                {
                    var m = await db.AJobTitle.FirstOrDefaultAsync(o => o.JobTitleId == JobTitle.JobTitleId);
                    if (m != null)
                    {
                        m.DepartmentId = JobTitle.DepartmentId;
                        m.ReportsTo = JobTitle.ReportsTo;
                        m.JobTitleDescription = JobTitle.JobTitleDescription;
                        db.Entry(m).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }

                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{JobTitle.JobTitleDescription} was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostJobTitle")]
        public async Task<IActionResult> PostJobTitle(AJobTitle JobTitle)
        {
            try
            {
                int id = 1;
                var last = db.AJobTitle.OrderBy(o => o.JobTitleId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.JobTitleId + 1);
                }
                JobTitle.JobTitleId = id;
                AJobTitle m = new();
                m.JobTitleId = id;
                m.DepartmentId = JobTitle.DepartmentId;
                m.ReportsTo = JobTitle.ReportsTo;
                m.JobTitleDescription = JobTitle.JobTitleDescription;
                db.AJobTitle.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{JobTitle.JobTitleDescription} was successfully Saved." });
        }
        #endregion Job Title
    }
}
