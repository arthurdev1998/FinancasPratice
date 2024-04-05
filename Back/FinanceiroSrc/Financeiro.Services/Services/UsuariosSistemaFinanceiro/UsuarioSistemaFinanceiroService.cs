using Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

namespace Financeiro.Services.Services.UsuariosSistemaFinanceiro;

public class UsuarioSistemaFinanceiroService
{
    private readonly IUsuarioSistemaFinanceiro _usuarioSistemaFinanceiro;

    public UsuarioSistemaFinanceiroService(IUsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
    {
        _usuarioSistemaFinanceiro = usuarioSistemaFinanceiro;
    }

    public async Task CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
    {
        await _usuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
    }
}