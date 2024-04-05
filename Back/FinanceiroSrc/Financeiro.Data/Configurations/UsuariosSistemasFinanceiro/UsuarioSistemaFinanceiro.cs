using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Common.Notifications;
using Financeiro.Data.Configurations.SistemasFinanceiros;

namespace Financeiro.Data.Configurations.UsuariosSistemasFinanceiro;

[Table("usuariosistemafinanceiro")]
public class UsuarioSistemaFinanceiro : Notification
{

    [Column("cod_serial_userfinacesystem")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("emailuser")]
    public string? EmailUser { get; set; }

    [Column("admin")]
    public bool Admin { get; set; }

    [Column("sistemaatual")]
    public bool SistemaAtual { get; set; }

    [ForeignKey("SistemaFinanceiro")]
    [Column(Order = 1)]
    public int SistemaId { get; set; }

    public SistemaFinanceiro? SistemaFinanceiro { get; set; }
}