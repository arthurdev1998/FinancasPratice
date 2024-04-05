using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Common.Notifications;
using Financeiro.Data.Configurations.SistemasFinanceiros;

namespace Financeiro.Data.Configurations.Categorias;

[Table("categoria")]
public class Categoria : Notification
{
    [Column("cod_serial_categoria")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [ForeignKey("SistemaFinanceiro")]
    [Column(Order = 1)]
    public int IdSistema { get; set; }

    public virtual SistemaFinanceiro? SistemaFinanceiro { get; set; }
}