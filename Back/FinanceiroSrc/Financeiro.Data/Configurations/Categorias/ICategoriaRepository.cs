using Financeiro.Common.Messages;

namespace Financeiro.Data.Configurations.Categorias;

public interface ICategoriaRepository
{
    public Task<ServiceResult<Categoria>> GetById(int id);
}