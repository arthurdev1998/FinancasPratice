using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Configurations.Categorias;
using static Financeiro.Common.Messages.ServiceResult<Financeiro.Common.Dtos.Categorias.CategoriaDto>;

namespace Financeiro.Services.Services.CategoriaServices;

public class DeleteCategoryHandler
{
    private readonly CategoriaRepository _categoriaRepository;
    private readonly IUnitofWork _unitofWork;

    public DeleteCategoryHandler(CategoriaRepository categoriaRepository, 
                                    IUnitofWork unitofWork)
    {
        _categoriaRepository = categoriaRepository;
        _unitofWork = unitofWork;
    }

    public async Task<ServiceResults> ExecuteAsync(int id)
    {
        var registro = _categoriaRepository.GetById(id);

        if (registro.Result == null)
            return new ServiceResults($"registro nao encontrado {nameof(id)}: {id}");

        await _categoriaRepository.Remove(registro.Result);
        await _unitofWork.Commit();

        return new ServiceResults();
    }
}