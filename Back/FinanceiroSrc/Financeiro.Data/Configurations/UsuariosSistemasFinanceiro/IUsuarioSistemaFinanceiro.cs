using Financeiro.Data.Configurations.Bases;

namespace Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

public interface IUsuarioSistemaFinanceiro : InterfaceGeneric<UsuarioSistemaFinanceiro>
{
    Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema);
    Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);
    Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario);
}