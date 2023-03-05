using CarteiraDigitalAPI.Dtos.Usuario;
using eWallet.API.Configurations.Token;
using eWallet.API.DTOs.Usuario;
using eWallet.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace eWallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/v1/IdentityLogin")]
        public async Task<IActionResult> IdentityLogin([FromBody] UserLoginDto login)
        {
            if (string.IsNullOrWhiteSpace(login.Email) || string.IsNullOrWhiteSpace(login.Password))
            {
                return Unauthorized();
            }

            var result = await
                _signInManager.PasswordSignInAsync(login.Email, login.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                // Recupera Usuário logado
                var userCurrent = await _userManager.FindByEmailAsync(login.Email);
                var userId = userCurrent.Id;

                var token = new TokenJWTBuilder()
                    .AddSecurityKey(JwtSecurityKey.Create("Secret_Key-12345678"))
                    .AddSubject("eWallet")
                    .AddIssuer("Teste.Secuiry.Bearer")
                    .AddAudience("Teste.Secuiry.Bearer")
                    .AddClaim("userId", userId)
                    .AddExpiry(30)
                    .Builder();


                var res = new GetLoginDto
                {
                    FirstName = userCurrent.FirstName,
                    LastName = userCurrent.LastName,
                    Email = login.Email,
                    Token = token.value
                };

                return Ok(res);
            }
            else
            {
                return Unauthorized();
            }
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/v1/CreateIdentityUser")]
        public async Task<IActionResult> CreateIdentityUser([FromBody] UserRegisterDto register)
        {
            if (string.IsNullOrWhiteSpace(register.Email) || string.IsNullOrWhiteSpace(register.Password))
                return Ok("");

            var user = new ApplicationUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                UserName = register.Email,
                Email = register.Email,
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Errors.Any())
            {
                return Ok(result.Errors);
            }

            // Geração de Confirmação caso precise
            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            // Retorno email
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var res = await _userManager.ConfirmEmailAsync(user, code);

            if (res.Succeeded)
            {
                return Ok("Usuário adicionado com sucesso");
            }
            else
            {
                return Ok("Erro ao confirmar usuários");
            }
        }
    }
}
