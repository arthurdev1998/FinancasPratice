using Financeiro.Data.Data;

namespace Financeiro.Data.Configurations.Bases;

public interface IRespositoryBase<T> where T: class
{
    public Task<T[]> GetAll(bool asnotracking = false);
    public Task<T> Update(T obj, bool asnotracking = false);
    public Task Remove(T obj);
}