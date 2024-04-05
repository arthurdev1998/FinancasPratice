using Financeiro.Data.Configurations.Bases;

namespace Financeiro.Data.Configurations.Despesas;

public interface IDespesaRepository : InterfaceGeneric<Despesa>
{
    Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario);
    Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
}
