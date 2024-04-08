using Financeiro.Common.Dtos.Usuarios;
using Financeiro.Data.Configurations.ApplicationUsers;

namespace Financeiro.Services.Services.MapperExtension.UsuarioMappers;

public static class UsuarioDtoMapper
{
    public static UsuarioDto MapToNewUsuarioDto(ApplicationUser src)
    {
        return new UsuarioDto
        {
            Id = src.Id,
            Login = src.Email
        };
    }

    public static List<UsuarioDto> MapToNewUsuarioDto(ICollection<ApplicationUser> src)
    {
        return src.Select(x => MapToNewUsuarioDto(x)).ToList();
    }
}