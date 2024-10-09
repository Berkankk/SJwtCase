using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SJwtCase.IdentityServer.Dtos;
using SJwtCase.IdentityServer.Models;
using System.Threading.Tasks;

namespace SJwtCase.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;  //giriş işlemleri için bunu kullanıyoruz

        public LoginController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false, false);
            if (result.Succeeded)
            {
                return Ok("Kullanıcı giriş işlemi başarılı");
            }
            return BadRequest("Kullanıcı adı veya şifre hatalı");
        }
    }
}
