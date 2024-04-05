using Financeiro.Data.Configurations.SistemasFinanceiros;

namespace Financeiro.Services.Services.SistemasFinanceiros;

public class SistemaFinanceniroService
{
    private readonly ISistemaFinanceiro _sistemaFinanceiro;

    public SistemaFinanceniroService(ISistemaFinanceiro sistemaFinanceiroRepository)
    {
        _sistemaFinanceiro = sistemaFinanceiroRepository;
    }

    public async Task AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
    {
        var valido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Name, nameof(sistemaFinanceiro.Name));
        if (valido)
        {
            var data = DateTime.Now;
            sistemaFinanceiro.DiaDeFechamento = 1;
            sistemaFinanceiro.Ano = data.Year;
            sistemaFinanceiro.Mes = data.Month;
            sistemaFinanceiro.AnoCopia = data.Year;
            sistemaFinanceiro.MesCopia = data.Month;
            sistemaFinanceiro.GerarCopiaDespesa = true;

            await _sistemaFinanceiro.Add(sistemaFinanceiro);
        }
    }

    public async Task AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
    {
        var valido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Name, nameof(sistemaFinanceiro.Name));

        if (valido)
        {
            sistemaFinanceiro.DiaDeFechamento = 1;
            await _sistemaFinanceiro.Update(sistemaFinanceiro);
        }
    }
}