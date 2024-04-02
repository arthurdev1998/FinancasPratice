using Financeiro.Data.Configurations.Bases;

namespace Financeiro.Data.Configurations.Categorias;

public interface InterfaceCategoria: InterfaceGeneric<Categoria>
{
    Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario);
}