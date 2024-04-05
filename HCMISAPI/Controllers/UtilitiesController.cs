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
    public class UtilitiesController : ControllerBase
    {
        private readonly HCMISContext db;
        public UtilitiesController(HCMISContext _db)
        {
            this.db = _db;
        }
        #region Department
        [Authorize]
        [HttpGet]
        [Route("GetDepartment")]
        public async Task<List<ADepartment>> GetDepartment()
        {
            List<ADepartment> m = new List<ADepartment>();
            var data = await db.ADepartment.ToListAsync();
            if (data == null)
            {
                return m;
            }

            return data;
        }
        [Authorize]
        [HttpGet]
        [Route("GetOrgStructureDepartment")]
        public async Task<List<ViewOrgStructureDepartment>> GetOrgStructureDepartment()
        {
            List<ViewOrgStructureDepartment> m = new List<ViewOrgStructureDepartment>();
            var data = await db.ViewOrgStructureDepartment.ToListAsync();
            if (data == null)
            {
                return m;
            }

            return data;
        }

        [Authorize]
        [HttpPut]
        [Route("PutDepartment")]
        public async Task<IActionResult> UpdateDepartment(ADepartment Department)
        {
            if (Department.DepartmentId > 0)
            {
                try
                {
                    var m = await db.ADepartment.FirstOrDefaultAsync(o => o.DepartmentId == Department.DepartmentId);
                    if (m != null)
                    {
                        m.DepartmentId = Department.DepartmentId;
                        m.ReportsTo = Department.ReportsTo;
                        m.DepartmentDescription = Department.DepartmentDescription;
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
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{Department.DepartmentDescription} was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostDepartment")]
        public async Task<IActionResult> PostDepartment(ADepartment Department)
        {
            try
            {
                int id = 1;
                var last = db.ADepartment.OrderBy(o => o.DepartmentId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.DepartmentId + 1);
                }
                Department.DepartmentId = id;
                ADepartment m = new();
                m.DepartmentId = id;
                m.DepartmentId = Department.DepartmentId;
                m.ReportsTo = Department.ReportsTo;
                m.DepartmentDescription = Department.DepartmentDescription;
                db.ADepartment.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{Department.DepartmentDescription} was successfully Saved." });
        }
        #endregion Department
        #region Job Title
        [Authorize]
        [HttpGet]
        [Route("GetOrgStructureJobTitle")]
        public async Task<List<ViewOrgStructureJobTitle>> GetOrgStructureJobTitle()
        {
            List<ViewOrgStructureJobTitle> m = new List<ViewOrgStructureJobTitle>();
            var data = await db.ViewOrgStructureJobTitle.ToListAsync();
            if (data == null)
            {
                return m;
            }

            return data;
        }
        #endregion Job Title
    }
}
