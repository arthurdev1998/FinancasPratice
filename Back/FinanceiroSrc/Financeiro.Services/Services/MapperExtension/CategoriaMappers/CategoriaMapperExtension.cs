using Financeiro.Common.Dtos.Categorias;
using Financeiro.Common.Messages;
using Financeiro.Data.Configurations.Categorias;

namespace Financeiro.Services.Services.MapperExtension.CategoriaMappers;

public static class CategoriaMapperExtension
{
    public static T MapTo<T>(this Categoria src)
    {
        var categorias = new List<Categoria>{src};
        return categorias.MapTo<List<T>>().First();
    }

    public static T MapTo<T>(this ICollection<Categoria> src)
    {
        var typeInterface = typeof(T).GetInterfaces();

        if(typeInterface.Any(x => x == typeof(ICollection<CategoriaDto>)))
        {
            return (T)(object)src.MapToCategoriaDto();
        }

        return MapperExtensionMessage.NotImplemented<T>();
    }
}