namespace Financeiro.Data.Configurations.Bases;

public interface IUnitofWork : IDisposable
{
    public Task<bool> Commit();
}
