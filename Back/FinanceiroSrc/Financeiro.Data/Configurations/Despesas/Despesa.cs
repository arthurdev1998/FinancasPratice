using System.ComponentModel.DataAnnotations.Schema;
using Financeiro.Common.Enums;
using Financeiro.Data.Configurations.Categorias;

namespace Financeiro.Data.Configurations.Despesas;

[Table("despesa")]
public class Despesa
{
    [Column("cod_serial_despesa")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("valor")]
    public decimal Valor { get; set; }

    [Column("mes")]
    public int Mes { get; set; }

    [Column("ano")]
    public int Ano { get; set; }

    [Column("tipodespesa")]
    public EnumTipoDespesa TipoDespesa { get; set; }

    [Column("datacadastro")]
    public DateTime DataCadastro { get; set; }

    [Column("dataalteracao")]
    public DateTime DataAlteracao { get; set; }

    [Column("datapagamento")]
    public DateTime DataPagamento { get; set; }

    [Column("datavencimento")]
    public DateTime DataVencimento { get; set; }

    [Column("pago")]
    public bool Pago { get; set; }

    [Column("despesaatrasada")]
    public bool DespesaAtrasada { get; set; }

    [ForeignKey("Categoria")]
    public int IdCategoria { get; set; }

    public Categoria? Categoria { get; set; }
}