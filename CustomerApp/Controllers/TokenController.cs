using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace CustomerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly List<string> allowedEmployees = new List<string>
        {"priyanshi21.patel@gmail.com", "hardik.trivedi@alterahealth.com", "dishant.buch@alterahealth.com" };

        public TokenController(IConfiguration config)
        {
            _configuration = config;
        }

        [HttpPost]
        [Route("{email}")]
        public ActionResult GenerateToken(string Email)
        {
            if(!string.IsNullOrEmpty(Email))
            {
                if(allowedEmployees.Contains(Email.ToLower()))
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("This User is not allowed.");
                }
            }
            else
            {
                return BadRequest("Email is Required.");
            }            
        }       
    }
}
