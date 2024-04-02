
#nullable disable

using System.Collections.Immutable;
using System.Runtime.InteropServices;
using Financeiro.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace Financeiro.Data.Configurations.Bases;

public class RepositoryGenerics<T> : InterfaceGeneric<T>, IDisposable where T : class
{
    private readonly AppDbContext _db;

    public RepositoryGenerics(AppDbContext db)
    {
        _db = db;
    }

    public async Task Add(T objeto)
    {
        await _db.Set<T>().AddAsync(objeto);
        await _db.SaveChangesAsync();
    }

    public async Task Delete(T objeto)
    {
        _db.Set<T>().Remove(objeto);
        await _db.SaveChangesAsync();
    }

    public async Task<T> GetEntityById(int id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public Task<List<T>> List()
    {
        return _db.Set<T>().ToListAsync();
    }

    public async Task Update(T objeto)
    {
        _db.Set<T>().Update(objeto);
        await _db.SaveChangesAsync();
    }

    #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    // Flag: Has Dispose already been called?
    bool disposed = false;
    // Instantiate a SafeHandle instance.
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            handle.Dispose();
            // Free any other managed objects here.
            //
        }

        disposed = true;
    }
    #endregion
}