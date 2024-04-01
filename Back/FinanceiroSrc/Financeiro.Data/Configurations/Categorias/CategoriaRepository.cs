

using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.Categorias;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    private readonly AppDbContext _db;
    private readonly IUnitofWork _unitofWork;

    public CategoriaRepository(AppDbContext db, IUnitofWork unitofWork) : base(db, unitofWork)
    {
        _db = db;
        _unitofWork = unitofWork;
    }

    public async Task<Categoria?> GetById(int? id)
    {
        return await _db.Categorias.SingleOrDefaultAsync(x => x.Id == id);
    }
}