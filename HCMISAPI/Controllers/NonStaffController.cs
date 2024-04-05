using HCMISAPI.Data;
using HCMISAPI.Emailing;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonStaffController : ControllerBase
    {
        private readonly HCMISContext db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment hostingEnv;
        public NonStaffController(UserManager<IdentityUser> userManager, 
            HCMISContext _db,
            IWebHostEnvironment _hostingEnv)
        {
            _userManager = userManager;
            db = _db;
            this.hostingEnv = _hostingEnv;
        }
        [HttpGet]
        [Route("GetRegistrationPrimartData")]
        public async Task<ExternalRegistrationModel> GetRegistrationPrimartData()
        {
            ExternalRegistrationModel m = new();

            m.Coutry=await db.ACountry.ToListAsync();
            m.Gender= await db.AGender.ToListAsync();
            m.IdentificationType= await db.AIdentificationType.ToListAsync();   
            m.District=await db.ADistrict.ToListAsync();
            m.SubCounty=await db.ASubCounty.ToListAsync();
            m.Village=await db.AVillage.ToListAsync();
            m.Parish=await db.AParish.ToListAsync();
            m.MaritalStatus=await db.AMaritalStatus.ToListAsync();
            m.Bank = await db.ABank.ToListAsync();
            m.LevelofEducation = await db.ALevelofEducation.ToListAsync();
            m.FieldOfStudy = await db.AFieldOfStudy.ToListAsync();
            m.SkillLevel = await db.ASkillLevel.ToListAsync();
            m.Relationship = await db.ARelationship.ToListAsync();
            m.LanguageProlific=await db.ALanguageProlific.ToListAsync();
            m.Languages=await db.ALanguages.ToListAsync();
            
            return m;
        }
        [HttpGet]
        [Route("GetNonStaffById/{NonStaffid}")]
        public async Task<NonStaff> GetNonStaffById(int NonStaffid)
        {
            var data = await db.NonStaff.FirstOrDefaultAsync(o=> o.NonStaffid==NonStaffid);
            if (data == null)
            {
                return new NonStaff();
            }
            return data;
        }
        
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateNonStaff([FromBody] NonStaff nonStaff)
        {
            if(nonStaff.NonStaffid > 0)
            {
                try
                {
                    db.Entry(nonStaff).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Profile was successfully updated." });
        }


        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] NonStaffRegistrationModel model)
        {
           // var emailexists = await db.NonStaff.FirstOrDefaultAsync(o=> o.EmailAddress== model.NewNonStaff.EmailAddress);
            var Userexists = await db.AspNetUsers.FirstOrDefaultAsync(o => o.Email == model.NewNonStaff.EmailAddress);
            if (Userexists != null)
            {
                return Ok(new Response { IsSuccess = false, Status = "Email already exists", Message = "The email address attached to this record already exists in the system and cannot be assigned to another account." });
            }
            else
            {
                var usernameExists = await db.AspNetUsers.FirstOrDefaultAsync(o => o.UserName == model.UserName);
                if(usernameExists != null)
                {
                    return Ok(new Response { IsSuccess = false, Status = "Username already exists", Message = "The Username attached to this record already exists in the system and cannot be assigned to another account." });
                }
                else
                {
                    var exists = await db.NonStaff.FirstOrDefaultAsync(o => (o.NonStaffid == model.NewNonStaff.NonStaffid) || (o.FirstName == model.NewNonStaff.FirstName && o.LastName == model.NewNonStaff.LastName && o.EmailAddress == model.NewNonStaff.EmailAddress));
                    if (exists != null)
                    {
                        model.NewNonStaff.NonStaffid = exists.NonStaffid;
                        db.Entry(model.NewNonStaff).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        int id = 1;
                        var lastrecord = db.NonStaff.OrderBy(o => o.NonStaffid).ToList().LastOrDefault();
                        if (lastrecord != null)
                        {
                            id = (lastrecord.NonStaffid + 1);
                        }
                        model.NewNonStaff.NonStaffid = id;
                        db.NonStaff.Add(model.NewNonStaff);
                        await db.SaveChangesAsync();
                    }
                    

                    IdentityUser user = new()
                    {
                        Email = model.NewNonStaff.EmailAddress,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        UserName = model.UserName
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (!result.Succeeded)
                        return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
                    else
                    {
                        var _result = await _userManager.AddToRoleAsync(user, "NON-STAFF");
                        if (!_result.Succeeded)
                            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User Role creation failed! Please check user details and try again." });
                        else
                        {
                            var _aspnetuser = await db.AspNetUsers.FirstOrDefaultAsync(o => o.UserName == model.UserName);
                            _aspnetuser.NonStaffid = model.NewNonStaff.NonStaffid;
                            db.Entry(_aspnetuser).State = EntityState.Modified;
                            await db.SaveChangesAsync();

                            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                            double id = 1;
                            var _last = db.AspNetEmailConfirmationCode.ToList().LastOrDefault();
                            if (_last != null)
                            {
                                id = (_last.ConfirmationId + 1);
                            }
                            AspNetEmailConfirmationCode x = new AspNetEmailConfirmationCode()
                            {
                                UserName = model.UserName,
                                ConfirmationCode = code,
                                CreationDate = DateTime.Now,
                                ConfirmationId = id
                            };
                            db.AspNetEmailConfirmationCode.Add(x);
                            db.SaveChanges();

                            byte[] c = System.Text.ASCIIEncoding.ASCII.GetBytes(model.UserName);
                            string username = Convert.ToBase64String(c);
                            string Link = $"{model.ComfirmationUrl}/{username}";

                            string message = "<p>Dear " + model.NewNonStaff.LastName +" "+ model.NewNonStaff.FirstName + ",</p><br/><br/> <p>An account has been created with the National Housing Construction Company Human Resource Management System.</p>" +
                                "<br/><p> Please click <a href='" + Link + "'>here</a> to activate this account in order to access this system.</p>" +
                                "<br/> <br/> Regards,<br/><br/> System Notification, <br/> National Housing Construction Company Uganda Limited.<br/><br/>" + DateTime.Now;

                            try
                            {
                                EmailModel email = new();
                                email.SendAccountActivationEmail(message, model.NewNonStaff.EmailAddress);
                            }
                            catch(Exception ex)
                            {
                                await _userManager.ConfirmEmailAsync(user, code);

                                var mresult = await _userManager.SetLockoutEnabledAsync(user, false);

                                return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Your account has been created successfully, Please return to the login page and use your credentials to access the system." });
                            }
                        }
                    }

                }
            }

            return Ok(new Response { Status = "Success",IsSuccess=true, Message = "Your account has been created successfully, Please log into your email address to activate your account." });
        }
        [HttpPost]
        [Route("ActivateUser")]
        public async Task<IActionResult> ActivateUser([FromBody] ActivationModel model)
        {
            byte[] c = Convert.FromBase64String(model.UserName);
            string _UserName = System.Text.ASCIIEncoding.ASCII.GetString(c);
            var user = await _userManager.FindByNameAsync(_UserName);
            var exists = db.AspNetEmailConfirmationCode.OrderBy(o => o.ConfirmationId).LastOrDefault(o => o.UserName == _UserName);
            if(exists != null)
            {
                await _userManager.ConfirmEmailAsync(user, exists.ConfirmationCode);

                await _userManager.SetLockoutEnabledAsync(user, false);

                exists.ConfirmationDate = DateTime.Now;
                db.Entry(exists).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = "Your account could not be activated, please contact the administrator for assistance." });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Your Account has been successfully activated." });
        }

        #region Qualification
        /// <summary>
        /// Returns qualifications for a given Non Staff
        /// </summary>
        /// <param name="NonStaffId"></param>
        /// <returns>NonStaffQualification list</returns>
        [Authorize]
        [HttpGet]
        [Route("GetQualificationForNonStaff/{NonStaffId}")]

        public async Task<List<NonStaffQualification>> GetQualificationForNonStaff(int NonStaffId)
        {
            List<NonStaffQualification> m = new();
            var data = await db.NonStaffQualification.Where(o => o.NonStaffid == NonStaffId).ToListAsync();
            if(data == null)
            {
                return m;
            }
            return data;
        }

        [Authorize]
        [HttpPut]
        [Route("UpdateQualificationForNonStaff")]
        public async Task<IActionResult> UpdateQualificationForNonStaff(_NonStaffQualification qualification)
        {
            if (qualification.QualificationId > 0)
            {
                try
                {
                    var m = await db.NonStaffQualification.FirstOrDefaultAsync(o => o.QualificationId == qualification.QualificationId);
                    if (m != null)
                    {
                        m.QualificationDocumentName = qualification.QualificationDocumentName;
                        m.QualificationDocumentExt = qualification.QualificationDocumentExt;
                        m.IsCurrent = qualification.IsCurrent;
                        m.EndDate = qualification.EndDate;
                        m.StartDate = qualification.StartDate;
                        m.NonStaffid = qualification.NonStaffid;
                        m.FieldOfStudyId = qualification.FieldOfStudyId;
                        m.LevelofEducationId = qualification.LevelofEducationId;
                        m.OtherFieldOfStudy = qualification.OtherFieldOfStudy;
                        m.InstitutionName = qualification.InstitutionName;
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
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Qualification was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostQualification")]
        public async Task<IActionResult> PostQualificationForNonStaff(_NonStaffQualification qualification)
        {
            try
            {
                int id = 1;
                var last = db.NonStaffQualification.OrderBy(o=> o.QualificationId).ToList().LastOrDefault();
                if(last != null)
                {
                    id = (last.QualificationId + 1);
                }
                qualification.QualificationId = id;
                NonStaffQualification m = new();
                m.QualificationId = id;
                m.QualificationDocumentName = qualification.QualificationDocumentName;
                m.QualificationDocumentExt=qualification.QualificationDocumentExt;
                m.IsCurrent = qualification.IsCurrent;
                m.EndDate = qualification.EndDate;
                m.StartDate = qualification.StartDate;
                m.NonStaffid = qualification.NonStaffid;
                m.FieldOfStudyId = qualification.FieldOfStudyId;
                m.LevelofEducationId= qualification.LevelofEducationId;
                m.OtherFieldOfStudy= qualification.OtherFieldOfStudy;
                m.InstitutionName = qualification.InstitutionName;
                db.NonStaffQualification.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Qualification was successfully Saved." });
        }
        #endregion Qualification
        #region Document Uploading
        // GET: api/NonStaff/DocumentUpload/5/www
        [HttpGet]
        [Route("DocumentUpload/{DocName}/{Rootfolder}")]
        public ActionResult<ImageUpload> GetDocumentUpload(string DocName,string Rootfolder)
        {

            if (!string.IsNullOrEmpty(DocName))
            {
                var path = hostingEnv.WebRootPath + $@"\NonStaffUpload\{Rootfolder}\{DocName}";
                if (System.IO.File.Exists(path))
                {
                    var bytes = System.IO.File.ReadAllBytes(path);
                    FileInfo fi = new FileInfo(path);
                    ImageUpload image = new ImageUpload();
                    image.Imagebyte = bytes;
                    image.ImageName = DocName;
                    image.ImageExt = fi.Extension;
                    return image;
                    //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    //result = "data:image/" + ext + ";base64," + base64String;
                }
                else
                {
                    return NotFound("Image doesnot exist.");
                }
            }
            else
            {
                return NotFound("Please provide the image name.");
            }
        }

        // POST: api/NonStaff/SaveDocumentUpload
        [HttpPost]
        [Route("SaveDocumentUpload")]
        public async Task<IActionResult> PostSaveDocumentUpload(ImageUpload Image)
        {
            try
            {
                var dir= hostingEnv.WebRootPath + $@"\NonStaffUpload\{Image.Rootfolder}";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var path = hostingEnv.WebRootPath + $@"\NonStaffUpload\{Image.Rootfolder}\{Image.ImageName}";

                //var path = @"path" + file.FileInfo.Name;
                if (!System.IO.File.Exists(path))
                {
                    FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                    MemoryStream ms = new MemoryStream(Image.Imagebyte);
                    ms.Position = 0;
                    ms.WriteTo(filestream);
                    await Task.Delay(15000);
                    filestream.Close();
                    ms.Close();
                }
                else
                {
                    System.IO.File.Delete(path);
                    FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                    MemoryStream ms = new MemoryStream(Image.Imagebyte);
                    ms.Position = 0;
                    ms.WriteTo(filestream);
                    await Task.Delay(15000);
                    filestream.Close();
                    ms.Close();
                }
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }

            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Document Successfully Uploaded." });
        }
        #endregion Document Uploading
        #region Work Experience
        [Authorize]
        [HttpGet]
        [Route("GetExperienceForNonStaff/{NonStaffId}")]

        public async Task<List<NonStaffWorkExperience>> GetExperienceForNonStaff(int NonStaffId)
        {
            List<NonStaffWorkExperience> m = new();
            var data = await db.NonStaffWorkExperience.Where(o => o.NonStaffid == NonStaffId).ToListAsync();
            if (data == null)
            {
                return m;
            }
            return data;
        }
        [Authorize]
        [HttpPut]
        [Route("PutExperience")]
        public async Task<IActionResult> PutExperience(_NonStaffWorkExperience WorkExperience)
        {
            if (WorkExperience.WorkExperienceId > 0)
            {
                try
                {
                    var m = await db.NonStaffWorkExperience.FirstOrDefaultAsync(o => o.WorkExperienceId == WorkExperience.WorkExperienceId);
                    if (m != null)
                    {
                        m.NonStaffid = WorkExperience.NonStaffid;
                        m.Organisation = WorkExperience.Organisation;
                        m.IsCurrent = WorkExperience.IsCurrent;
                        m.EndDate = WorkExperience.EndDate;
                        m.StartDate = WorkExperience.StartDate;
                        m.JobTitle = WorkExperience.JobTitle;
                        m.EmployerName = WorkExperience.EmployerName;
                        m.EmployerOfficialEmail = WorkExperience.EmployerOfficialEmail;
                        m.EmployerOfficialNumber = WorkExperience.EmployerOfficialNumber;
                        m.AppointmentLetterUrl = WorkExperience.AppointmentLetterUrl;
                        m.AppointmentLetterExt = WorkExperience.AppointmentLetterExt;
                        m.Responsibilities = WorkExperience.Responsibilities;
                        db.Entry(m).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    //db.Entry(WorkExperience).State= EntityState.Modified;
                    //await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Work Experience was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostExperience")]
        public async Task<IActionResult> PostExperience(_NonStaffWorkExperience WorkExperience)
        {
            try
            {
                int id = 1;
                var last = db.NonStaffWorkExperience.OrderBy(o => o.WorkExperienceId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.WorkExperienceId + 1);
                }
                WorkExperience.WorkExperienceId = id;
                NonStaffWorkExperience m = new();
                m.WorkExperienceId = id;
                m.NonStaffid = WorkExperience.NonStaffid;
                m.Organisation = WorkExperience.Organisation;
                m.IsCurrent = WorkExperience.IsCurrent;
                m.EndDate = WorkExperience.EndDate;
                m.StartDate = WorkExperience.StartDate;
                m.JobTitle = WorkExperience.JobTitle;
                m.EmployerName = WorkExperience.EmployerName;
                m.EmployerOfficialEmail = WorkExperience.EmployerOfficialEmail;
                m.EmployerOfficialNumber = WorkExperience.EmployerOfficialNumber;
                m.AppointmentLetterUrl = WorkExperience.AppointmentLetterUrl;
                m.AppointmentLetterExt = WorkExperience.AppointmentLetterExt;
                m.Responsibilities = WorkExperience.Responsibilities;
                db.NonStaffWorkExperience.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Work Experience was successfully Saved." });
        }
        #endregion Work Experience
        #region Skills
        [Authorize]
        [HttpGet]
        [Route("GetSkillsForNonStaff/{NonStaffId}")]

        public async Task<List<NonStaffSkills>> GetSkillsForNonStaff(int NonStaffId)
        {
            List<NonStaffSkills> m = new();
            var data = await db.NonStaffSkills.Where(o => o.NonStaffid == NonStaffId).ToListAsync();
            if (data == null)
            {
                return m;
            }
            return data;
        }
        [Authorize]
        [HttpPut]
        [Route("PutSkills")]
        public async Task<IActionResult> PutSkills(_NonStaffSkills Skills)
        {
            if (Skills.ExtraSkillsId > 0)
            {
                try
                {
                    var m = await db.NonStaffSkills.FirstOrDefaultAsync(o => o.ExtraSkillsId == Skills.ExtraSkillsId);
                    if (m != null)
                    {
                        m.NonStaffid = Skills.NonStaffid;
                        m.SkillDescription = Skills.SkillDescription;
                        m.SkillLevelId = Skills.SkillLevelId;
                        m.YearsofExperience = Skills.YearsofExperience;
                        db.Entry(m).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    //db.Entry(WorkExperience).State= EntityState.Modified;
                    //await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Skill was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostSkills")]
        public async Task<IActionResult> PostSkills(_NonStaffSkills Skills)
        {
            try
            {
                int id = 1;
                var last = db.NonStaffSkills.OrderBy(o => o.ExtraSkillsId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.ExtraSkillsId + 1);
                }
                Skills.ExtraSkillsId = id;
                NonStaffSkills m = new();
                m.ExtraSkillsId = id;
                m.NonStaffid = Skills.NonStaffid;
                m.SkillDescription = Skills.SkillDescription;
                m.SkillLevelId = Skills.SkillLevelId;
                m.YearsofExperience = Skills.YearsofExperience;
                db.NonStaffSkills.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = "Skill was successfully Saved." });
        }
        #endregion Skills
        #region Next of Kin
        [Authorize]
        [HttpGet]
        [Route("GetNextOfKinForNonStaff/{NonStaffId}")]

        public async Task<List<NonStaffNextOfKin>> GetNextOfKinForNonStaff(int NonStaffId)
        {
            List<NonStaffNextOfKin> m = new();
            var data = await db.NonStaffNextOfKin.Where(o => o.NonStaffid == NonStaffId).ToListAsync();
            if (data == null)
            {
                return m;
            }
            return data;
        }
        [Authorize]
        [HttpPut]
        [Route("PutNextOfKin")]
        public async Task<IActionResult> PutNextOfKin(_NonStaffNextOfKin NextOfKin)
        {
            if (NextOfKin.NonStaffNextOfKinId > 0)
            {
                try
                {
                    var m = await db.NonStaffNextOfKin.FirstOrDefaultAsync(o => o.NonStaffNextOfKinId == NextOfKin.NonStaffNextOfKinId);
                    if (m != null)
                    {
                        m.NonStaffid = NextOfKin.NonStaffid;
                        m.FirstName = NextOfKin.FirstName;
                        m.MiddleName = NextOfKin.MiddleName;
                        m.LastName = NextOfKin.LastName;
                        m.GenderId = NextOfKin.GenderId;
                        m.EmailAddress = NextOfKin.EmailAddress;
                        m.OfficialPhoneNumber = NextOfKin.OfficialPhoneNumber;
                        m.MobileNumber = NextOfKin.MobileNumber;
                        m.RelationshipId = NextOfKin.RelationshipId;
                        db.Entry(m).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    //db.Entry(WorkExperience).State= EntityState.Modified;
                    //await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{NextOfKin.FirstName} {NextOfKin.LastName} was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostNextOfKin")]
        public async Task<IActionResult> PostNextOfKin(_NonStaffNextOfKin NextOfKin)
        {
            try
            {
                int id = 1;
                var last = db.NonStaffNextOfKin.OrderBy(o => o.NonStaffNextOfKinId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.NonStaffNextOfKinId + 1);
                }
                NextOfKin.NonStaffNextOfKinId = id;
                NonStaffNextOfKin m = new();
                m.NonStaffNextOfKinId = id;
                m.NonStaffid = NextOfKin.NonStaffid;
                m.FirstName = NextOfKin.FirstName;
                m.MiddleName = NextOfKin.MiddleName;
                m.LastName = NextOfKin.LastName;
                m.GenderId = NextOfKin.GenderId;
                m.EmailAddress = NextOfKin.EmailAddress;
                m.OfficialPhoneNumber = NextOfKin.OfficialPhoneNumber;
                m.MobileNumber = NextOfKin.MobileNumber;
                m.RelationshipId = NextOfKin.RelationshipId;
                db.NonStaffNextOfKin.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"{NextOfKin.FirstName} {NextOfKin.LastName} was successfully Saved." });
        }
        #endregion Next of kin
        #region Languages Known
        [Authorize]
        [HttpGet]
        [Route("GetLanguagesKnownForNonStaff/{NonStaffId}")]

        public async Task<List<NonStaffLanguagesKnown>> GetLanguagesKnownForNonStaff(int NonStaffId)
        {
            List<NonStaffLanguagesKnown> m = new();
            var data = await db.NonStaffLanguagesKnown.Where(o => o.NonStaffid == NonStaffId).ToListAsync();
            if (data == null)
            {
                return m;
            }
            return data;
        }
        [Authorize]
        [HttpPut]
        [Route("PutLanguagesKnown")]
        public async Task<IActionResult> PutLanguagesKnown(_NonStaffLanguagesKnown LanguagesKnown)
        {
            if (LanguagesKnown.LanguagesKnownId > 0)
            {
                try
                {
                    var m = await db.NonStaffLanguagesKnown.FirstOrDefaultAsync(o => o.LanguagesKnownId == LanguagesKnown.LanguagesKnownId);
                    if (m != null)
                    {
                        m.NonStaffid = LanguagesKnown.NonStaffid;
                        m.LanguageId = LanguagesKnown.LanguageId;
                        m.LanguageProlificId = LanguagesKnown.LanguageProlificId;
                        db.Entry(m).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                    }
                    //db.Entry(WorkExperience).State= EntityState.Modified;
                    //await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
                }
            }
            else
                return Ok(new Response { Status = "Record not found", IsSuccess = false, Message = "This record was not found." });
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"Language was successfully updated." });
        }
        [Authorize]
        [HttpPost]
        [Route("PostLanguagesKnown")]
        public async Task<IActionResult> PostLanguagesKnown(_NonStaffLanguagesKnown LanguagesKnown)
        {
            try
            {
                int id = 1;
                var last = db.NonStaffLanguagesKnown.OrderBy(o => o.LanguagesKnownId).ToList().LastOrDefault();
                if (last != null)
                {
                    id = (last.LanguagesKnownId + 1);
                }
                LanguagesKnown.LanguagesKnownId = id;
                NonStaffLanguagesKnown m = new();
                m.LanguagesKnownId = id;
                m.NonStaffid = LanguagesKnown.NonStaffid;
                m.LanguageId = LanguagesKnown.LanguageId;
                m.LanguageProlificId = LanguagesKnown.LanguageProlificId;
                db.NonStaffLanguagesKnown.Add(m);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Status = "Error", IsSuccess = false, Message = ex.Message });
            }
            return Ok(new Response { Status = "Success", IsSuccess = true, Message = $"Language was successfully Saved." });
        }
        #endregion Languages Known
    }
}
