using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;

namespace Financeiro.Data.Configurations.SistemasFinanceiros;

public class SistemaFinanceiroRepository : RepositoryGenerics<SistemaFinanceiro>, ISistemaFinanceiro
{
    public SistemaFinanceiroRepository(AppDbContext db) : base(db)
    {}
    
    public Task<IList<SistemaFinanceiro>> ListaSistemasUsuario(string emailUsuario)
    {
        throw new NotImplementedException();
    }
}