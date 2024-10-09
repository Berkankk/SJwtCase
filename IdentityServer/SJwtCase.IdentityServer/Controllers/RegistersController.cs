using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.IdentityServer.Dtos;
using SJwtCase.IdentityServer.Models;
using System.Threading.Tasks;

namespace SJwtCase.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase  //Yeni kullanıcı kaydı
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDto registerDto)
        {
            var user = new ApplicationUser
            {
                Name = registerDto.Name,
                Email = registerDto.Email,
                Surname = registerDto.Surname,
                UserName = registerDto.UserName,
            };
            var result = await _userManager.CreateAsync(user, registerDto.Password); //kullanıcı gönderdik yanına şifreyi de gönderidk
            if (result.Succeeded)
            {
                return Ok("Kullanıcı başarıyla oluşturuldu");
            }
            return BadRequest(result.Errors);//400 lü durum kodu hataları göreceğiz böylelikle
        }
    }
}
