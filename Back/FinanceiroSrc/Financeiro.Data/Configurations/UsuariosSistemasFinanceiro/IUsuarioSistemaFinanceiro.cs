namespace Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

public interface IUsuarioSistemaFinanceiro
{
    Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema);
    Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);
    Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario);
}