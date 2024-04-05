using Financeiro.Data.Configurations.Bases;

namespace Financeiro.Data.Configurations.SistemasFinanceiros;

public interface ISistemaFinanceiro : InterfaceGeneric<SistemaFinanceiro>
{
    Task<IList<SistemaFinanceiro>> ListaSistemasUsuario(string emailUsuario);
}