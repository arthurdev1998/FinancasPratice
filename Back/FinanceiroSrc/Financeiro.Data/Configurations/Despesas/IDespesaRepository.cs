namespace Financeiro.Data.Configurations.Despesas;

public interface IDespesaRepository
{
    Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario);
    Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
}
