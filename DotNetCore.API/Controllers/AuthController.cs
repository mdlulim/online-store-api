using DotNetCore.API.CustomActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.API.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Azure.Identity;
using DotNetCore.API.Repositories.IRepository;
using System.Data;

namespace DotNetCore.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            _userManager = userManager;
            _tokenRepository = tokenRepository;
        }   

        [HttpPost]
        [Route("Register")]
        [ValidateModel]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerquestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerquestDto.Username,
                Email = registerquestDto.Username
            };

            var identityResult =  await _userManager.CreateAsync(identityUser, registerquestDto.Password);

            if(identityResult.Succeeded)
            {
                //Add user roles
                if(registerquestDto.Roles != null && registerquestDto.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerquestDto.Roles);
                    if(identityResult.Succeeded)
                    {
                        return Ok("User was registered! Please Login");
                    }
                }
                
            }

            return BadRequest("Something went wrong");

        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
           var user = await _userManager.FindByEmailAsync(loginRequestDto.Username);
            if(user != null)
            {
                var checkPassword = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                if (checkPassword)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    var jwtToken = _tokenRepository.CreateJWTToken(user, roles.ToList());

                    var response = new LoginResponseDto
                    {
                        Email = user.Email,
                        Roles = roles.ToArray(),
                        JwtToken = jwtToken
                    };
                    return Ok(new ResponseDto { Success = true, Message = "Login successful", Data = response });
                }
            }

            return Ok(new ResponseDto { Success = false, Message = "Username or password incorrect", Data = null });
        }

    }
}
