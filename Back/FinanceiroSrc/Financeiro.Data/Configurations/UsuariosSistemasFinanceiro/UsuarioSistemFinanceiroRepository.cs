#nullable disable

using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

public class UsuarioSistemFinanceiroRepository : RepositoryGenerics<UsuarioSistemaFinanceiro>, IUsuarioSistemaFinanceiro
{
    private readonly AppDbContext _db;

    public UsuarioSistemFinanceiroRepository(AppDbContext db): base(db)
    {
        _db = db;
    }
    
    public async Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema)
    {
        return await _db.UsuarioSistemaFinanceiros.Where(x => x.SistemaId == IdSistema).AsNoTracking().ToListAsync();
    }

    public async Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario)
    {   
        return await _db.UsuarioSistemaFinanceiros.AsNoTracking().FirstOrDefaultAsync(x => x.EmailUser == emailUsuario);
    }

    public async Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
    {    
       _db.UsuarioSistemaFinanceiros.RemoveRange(usuarios);
       await _db.SaveChangesAsync();
    }
}
