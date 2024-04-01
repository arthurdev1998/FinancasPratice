using Financeiro.Common.Dtos.Categorias;
using Financeiro.Common.Messages;
using Financeiro.Data.Configurations.Categorias;
using Financeiro.Services.Services.MapperExtension.CategoriaMappers;

namespace Financeiro.Services.Services.CategoriaServices;

public class GetAllCategoryHandler
{
    private readonly CategoriaRepository _categoriaRepository;

    public GetAllCategoryHandler(CategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<ServiceResult<CategoriaDto>> ExecuteAsync(bool asnotracking = true)
    {
        var registro = await _categoriaRepository.GetAll(asnotracking);
        return new ServiceResult<CategoriaDto>(registro?.MapTo<CategoriaDto>());
    }
}