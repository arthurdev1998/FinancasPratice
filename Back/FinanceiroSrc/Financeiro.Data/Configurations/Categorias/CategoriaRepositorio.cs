using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.Categorias;

public class CategoriaRepositorio : RepositoryGenerics<Categoria>, InterfaceCategoria
{
    private readonly AppDbContext _db;

    public CategoriaRepositorio(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario)
    {
        return await (from s in _db.SistemaFinanceiros
                      join c in _db.Categorias on s.Id equals c.IdSistema
                      join us in _db.UsuarioSistemaFinanceiros on s.Id equals us.SistemaId
                      where us.EmailUser!.Equals(emailUsuario) && us.SistemaAtual
                      select c).AsNoTracking().ToListAsync();
    }
}