using Financeiro.Common.Messages;

namespace Financeiro.Data.Configurations.Categorias;

public interface ICategoriaRepository
{
    public Task<Categoria>? GetById(int? id);
}
