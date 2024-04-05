using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Common.Notifications;

namespace Financeiro.Data.Configurations.SistemasFinanceiros;

[Table("sistemafinanceiro")]
public class SistemaFinanceiro :Notification
{
    [Column("cod_serial_sistemafinanceiro")]
    public int Id { get; set; }

    [Column("nome")]
    public string? Name { get; set; }

    [Column("mes")]
    public int Mes { get; set; }

    [Column("ano")]
    public int Ano { get; set; }

    [Column("diadefechamento")]
    public int DiaDeFechamento { get; set; }

    [Column("gerarcopiadespesa")]
    public bool GerarCopiaDespesa { get; set; }

    [Column("mescopia")]
    public int MesCopia { get; set; }

    [Column("anocopia")]
    public int AnoCopia { get; set; }
}