using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using api.data.dtos;
using api.entities;
using api.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace OnlineValveApplication_02.Controllers
{
   
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }

         [HttpPost("api/register")]
        public async Task<IActionResult> Register(UserForLogin ufr)
        {
            ufr.username = ufr.username.ToLower();
            if (await _repo.UserExists(ufr.username)) { return BadRequest("User already exists ..."); }
            AppUser test = new AppUser { username = ufr.username };
            var createdUser = await _repo.Register(test, ufr.password);
            return StatusCode(201);
        } 

        [HttpPost("api/login")]
        public async Task<IActionResult> Login(UserForLogin ufl)
        {
            var userFromRepo = await _repo.Login(ufl.username.ToLower(), ufl.password);
            
            if (userFromRepo == null) { return BadRequest("Unauthorized"); }
            // generate a token
            var claims = new[] {
        new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
        new Claim(ClaimTypes.Name, userFromRepo.username)
        };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var tokendescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };
            var tokenhandler = new JwtSecurityTokenHandler();
            var token = tokenhandler.CreateToken(tokendescriptor);
            var ret = new UserForReturn();
            ret.username = userFromRepo.username;
            var help = new {token = tokenhandler.WriteToken(token)};
            ret.token = help.token;
            
            return Ok(ret);
            

        }

       /*  [HttpPut("update")]
        public async Task<IActionResult> Update(UserForRegister ufr)
        {
            var result = "";
            ufr.username = ufr.username.ToLower();
            if (await _repo.UserExists(ufr.username)) {
                AppUser test = await _repo.getUserByName(ufr.username);
                result = await _repo.updatePassword(test, ufr.password);
             }
            return Ok(result);
        } */
        
    }
}