using Financeiro.Data.Configurations.Despesas;

namespace Financeiro.Services.Services.Despesas;

public class DespesaService
{
    private readonly IDespesaRepository _despesaRepository;

    public DespesaService(IDespesaRepository despesaRepository)
    {
        _despesaRepository = despesaRepository;
    }

    public async Task AdicionarDespesa(Despesa despesa)
    {
        var data = DateTime.UtcNow;
        despesa.DataCadastro = data;
        despesa.Ano = data.Year;
        despesa.Mes = data.Month;

        var valido = despesa.ValidarPropriedadeString(despesa.Name, nameof(despesa.Name));
        if (valido)
            await _despesaRepository.Add(despesa);
    }

    public async Task AtualizarDespesa(Despesa despesa)
    {
        var data = DateTime.UtcNow;
        despesa.DataAlteracao = data;

        if (despesa.Pago)
        {
            despesa.DataPagamento = data;
        }

        var valido = despesa.ValidarPropriedadeString(despesa.Name, nameof(despesa.Name));
        if (valido)
            await _despesaRepository.Update(despesa);
    }
}