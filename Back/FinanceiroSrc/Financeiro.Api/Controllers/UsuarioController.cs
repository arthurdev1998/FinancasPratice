using System.Text;
using Financeiro.Common.Dtos.Usuarios;
using Financeiro.Common.Models;
using Financeiro.Data.Configurations.ApplicationUsers;
using Financeiro.Services.Services.Usuarios;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Financeiro.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserService _userService;

    public UsuarioController(UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        UserService userService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _userService = userService;
    }

    [Produces("application/json")]
    [HttpPost("/api/AdicionaUsuario")]
    public async Task<IActionResult> AdicionaUsuario([FromBody] Login login)
    {
        if (string.IsNullOrWhiteSpace(login.Email) ||
            string.IsNullOrWhiteSpace(login.Senha) ||
            string.IsNullOrWhiteSpace(login.Cpf))
        {
            return Ok("Falta alguns dados");
        }

        var user = new ApplicationUser
        {
            Email = login.Email,
            UserName = login.Email,
            Cpf = login.Cpf
        };

        var result = await _userManager.CreateAsync(user, login.Senha);

        if (result.Errors.Any())
        {
            return Ok(result.Errors);
        }

        // Geração de confirmação caso precise 
        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

        // retorno do email 
        code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));

        var respose_Retorn = await _userManager.ConfirmEmailAsync(user, code);

        if (respose_Retorn.Succeeded)
        {
            return Ok("Usuário Adicionado!");
        }
        else
        {
            return Ok("erro ao confirmar cadastro de usuário!");
        }

    }

    [HttpGet]
    [ProducesResponseType(typeof(List<UsuarioDto>),200)]
    public async Task<ActionResult<List<UsuarioDto>>> GetAllUsers()
    {
        var usuarios =  await _userService.GetAllUsers();
        return Ok(usuarios);
    }
}