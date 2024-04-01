
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Configurations.Bases;

public class Repository<U>(AppDbContext db, IUnitofWork unitofWork) : IRespositoryBase<U> where U : class
{
    private readonly AppDbContext _db = db;
    private readonly IUnitofWork _unitofWork = unitofWork;

    public async Task<U[]> GetAll(bool asnotracking = false)
    {
        IQueryable<U> query = _db.Set<U>();

        return asnotracking ?
        await query.AsNoTracking().ToArrayAsync() :
        await query.ToArrayAsync();
    }

    public async Task<U> Update(U entity, bool asnotracking = false)
    {
        _db.Update(entity);
       await _unitofWork.Commit();
       return entity;
    }

    public async Task Remove(U obj)
    {
        _db.Remove(obj);
        await _unitofWork.Commit();
    }
}