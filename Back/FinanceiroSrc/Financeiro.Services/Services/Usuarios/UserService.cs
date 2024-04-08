using Financeiro.Common.Dtos.Usuarios;
using Financeiro.Data.Configurations.ApplicationUsers;
using Financeiro.Services.Services.MapperExtension.UsuarioMappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Services.Services.Usuarios;

public class UserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IEnumerable<UsuarioDto>> GetAllUsers()
    {
        var registros = await _userManager.Users.AsNoTracking().ToListAsync();

        if (registros == null)
            return [];

        return registros.MapTo<List<UsuarioDto>>();
    }
}