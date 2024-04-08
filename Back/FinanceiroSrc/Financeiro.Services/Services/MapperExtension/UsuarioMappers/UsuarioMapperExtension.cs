using Financeiro.Common.Dtos.Usuarios;
using Financeiro.Common.Messages;
using Financeiro.Data.Configurations.ApplicationUsers;

namespace Financeiro.Services.Services.MapperExtension.UsuarioMappers;

public static class UsuarioMapperExtension
{
    public static T MapTo<T>(this ApplicationUser src)
    {
        var usuarios = new List<ApplicationUser> { src };

        return usuarios.MapTo<List<T>>().First();
    }

    public static T MapTo<T>(this ICollection<ApplicationUser> src)
    {
        var typeInterface = typeof(T).GetInterfaces();

        if (typeInterface.Any(x => x == typeof(ICollection<UsuarioDto>)))
        {
            return (T)(object)UsuarioDtoMapper.MapToNewUsuarioDto(src);
        }

        return MapperExtensionMessage.NotImplemented<T>();
    }

    public static ApplicationUser MapToNew(this UsuarioInsertDto dto)
    {
        return new ApplicationUser
        {
            Email = dto.Email,
            Cpf = dto.Cpf,
        };
    }

    public static void MapOver(this UsuarioUpdateDto dto, ApplicationUser usuario)
    {
        usuario.Cpf = dto.Cpf;
    } 
}