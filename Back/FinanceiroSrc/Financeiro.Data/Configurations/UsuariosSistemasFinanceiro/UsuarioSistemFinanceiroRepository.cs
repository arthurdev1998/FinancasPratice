using Financeiro.Data.Configurations.Bases;
using Financeiro.Data.Data;

namespace Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

public class UsuarioSistemFinanceiroRepository : RepositoryGenerics<UsuarioSistemaFinanceiro>, IUsuarioSistemaFinanceiro
{
    public UsuarioSistemFinanceiroRepository(AppDbContext db): base(db)
    {}
    
    public Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario)
    {
        throw new NotImplementedException();
    }

    public Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
    {
        throw new NotImplementedException();
    }
}
