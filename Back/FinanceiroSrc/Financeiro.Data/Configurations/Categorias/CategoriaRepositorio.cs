using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;

namespace Financeiro.Data.Configurations.Categorias;

public class CategoriaRepositorio : RepositoryGenerics<Categoria>, InterfaceCategoria
{
    public CategoriaRepositorio(AppDbContext db) : base(db)
    {}
    
    public Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario)
    {
        throw new NotImplementedException();
    }
}
