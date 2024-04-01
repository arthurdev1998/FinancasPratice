using Financeiro.Common.Dtos.Categorias;
using Financeiro.Data.Configurations.Categorias;

namespace Financeiro.Services.Services.MapperExtension.CategoriaMappers;

public static class CategoriaDtoMapper
{
    public static CategoriaDto MapToCategoriaDto(this Categoria src)
    {
        return new CategoriaDto
        {
            Id = src.Id,
            Nome = src.Name
        };
    }

    public static List<CategoriaDto> MapToCategoriaDto(this ICollection<Categoria> src)
    {
        return src.Select(x => MapToCategoriaDto(x)).ToList();
    }
}