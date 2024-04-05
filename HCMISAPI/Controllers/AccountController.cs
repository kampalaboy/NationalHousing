using HCMISAPI.Data;
using HCMISAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HCMISAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly HCMISContext db;

        public AccountController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            HCMISContext _db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            db = _db;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var userexists = db.AspNetUsers.FirstOrDefault(o => o.UserName == model.Username || o.Email == model.Username);
            if(userexists == null)
            {
                return Unauthorized();
            }
            var user = await _userManager.FindByNameAsync(userexists.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var lockedout = await _userManager.IsLockedOutAsync(user);
                if (!lockedout)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);

                    if (userRoles.Count > 0)
                    {
                        var authClaims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.UserName),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        };

                        foreach (var userRole in userRoles)
                        {
                            authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                        }

                        var token = GetToken(authClaims);
                        int id = 0;
                        var aspdata = db.AspNetUsers.FirstOrDefault(o => o.UserName == user.UserName);
                        if(aspdata != null)
                        {
                            if(aspdata.NonStaffid != null)
                            {
                                id = aspdata.NonStaffid.Value;
                            }
                            else if(aspdata.Employeeid != null)
                            {
                                id = aspdata.Employeeid.Value;
                            }
                        }

                        return Ok(new LoginResultModel()
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo,
                            IsSuccess = true,
                            UserRole = userRoles[0],
                            AccountHolderName= userexists.UserName,
                            StaffId = id,
                        });
                    }
                    //else
                    //{
                    //    return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
                    //}
                }
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
            else
            {
                var _result = await _userManager.AddToRoleAsync(user, model.UserRole);
                if(!_result.Succeeded)
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User Role creation failed! Please check user details and try again." });
                else
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    await _userManager.ConfirmEmailAsync(user, code);

                    var mresult = await _userManager.SetLockoutEnabledAsync(user, false);

                    //var newuser = _context.AspNetUsers.FirstOrDefault(o => o.UserName == _client.EmailAddress);
                    //if (newuser != null)
                    //{
                    //    newuser.ClientId = _client.ClientId;
                    //    _context.Entry(newuser).State = EntityState.Modified;
                    //    _context.SaveChanges();
                    //}
                    //NotificationSender email = new NotificationSender();
                    //email.SendAccountConfirmedByFinanceEmail(Message, _client.EmailAddress);
                }
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            //if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
            //    await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            //if (!await _roleManager.RoleExistsAsync(UserRoles.User))
            //    await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            //if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
            //{
            //    await _userManager.AddToRoleAsync(user, UserRoles.Admin);
            //}
            //if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
            //{
            //    await _userManager.AddToRoleAsync(user, UserRoles.User);
            //}
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(12),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
