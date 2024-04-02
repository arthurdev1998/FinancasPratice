using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;

namespace Financeiro.Data.Configurations.Despesas;

public class DespesaRepository : RepositoryGenerics<Despesa>, IDespesaRepository
{
    public DespesaRepository(AppDbContext db): base(db)
    {}
    
    public Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
    {
        throw new NotImplementedException();
    }
}