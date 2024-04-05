using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.SistemasFinanceiros;

public class SistemaFinanceiroRepository : RepositoryGenerics<SistemaFinanceiro>, ISistemaFinanceiro
{
    private readonly AppDbContext _db;
    public SistemaFinanceiroRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IList<SistemaFinanceiro>> ListaSistemasUsuario(string emailUsuario)
    {
        return await (from s in _db.SistemaFinanceiros
                      join us in _db.UsuarioSistemaFinanceiros on s.Id equals us.SistemaId
                      where us.EmailUser!.Equals(emailUsuario)
                      select s).AsNoTracking().ToListAsync();
    }
}