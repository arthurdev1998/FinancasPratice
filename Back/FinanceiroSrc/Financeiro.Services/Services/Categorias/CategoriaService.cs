using Financeiro.Data.Configurations.Categorias;

namespace Financeiro.Services.Services.Categorias;

public class CategoriaService
{
    private readonly InterfaceCategoria _categoriaRepository;

    public CategoriaService(InterfaceCategoria categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task AdicionarCategoria(Categoria categoria)
    {
        var valido = categoria.ValidarPropriedadeString(categoria.Name, nameof(categoria.Name));
        if (valido)
            await _categoriaRepository.Add(categoria);
    }

    public async Task AtualizarCategoria(Categoria categoria)
    {
        var valido = categoria.ValidarPropriedadeString(categoria.Name, nameof(categoria.Name));
        if (valido)
            await _categoriaRepository.Update(categoria);
    }
}