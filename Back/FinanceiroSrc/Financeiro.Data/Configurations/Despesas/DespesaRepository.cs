using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.Despesas;

public class DespesaRepository : RepositoryGenerics<Despesa>, IDespesaRepository
{
    private readonly AppDbContext _db;
    public DespesaRepository(AppDbContext db): base(db)
    {
        _db = db;
    }
    
    public async Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario)
    {
        return await (from s in _db.SistemaFinanceiros
                    join c in _db.Categorias on s.Id equals c.IdSistema
                    join us in _db.UsuarioSistemaFinanceiros on s.Id equals us.SistemaId
                    join d in _db.Despesas on c.Id equals d.IdCategoria
                    where us.EmailUser!.Equals(emailUsuario) && s.Mes == d.Mes && s.Ano == d.Ano
                    select d
                    ).AsNoTracking().ToListAsync();
    }

    public async Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
    {
        return await (from s in _db.SistemaFinanceiros
                    join c in _db.Categorias on s.Id equals c.IdSistema
                    join us in _db.UsuarioSistemaFinanceiros on s.Id equals us.SistemaId
                    join d in _db.Despesas on c.Id equals d.IdCategoria
                    where us.EmailUser!.Equals(emailUsuario) && d.Mes < DateTime.Now.Month && !d.Pago
                    select d
                    ).AsNoTracking().ToListAsync();
    }
}