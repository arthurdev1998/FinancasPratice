namespace Financeiro.Data.Configurations.SistemasFinanceiros;

public interface ISistemaFinanceiro
{
    Task<IList<SistemaFinanceiro>> ListaSistemasUsuario(string emailUsuario);
}