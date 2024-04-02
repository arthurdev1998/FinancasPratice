using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sistemafinanceiro",
                columns: table => new
                {
                    cod_serial_sistemafinanceiro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mes = table.Column<int>(type: "int", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    diadefechamento = table.Column<int>(type: "int", nullable: false),
                    gerarcopiadespesa = table.Column<bool>(type: "bit", nullable: false),
                    mescopia = table.Column<int>(type: "int", nullable: false),
                    anocopia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sistemafinanceiro", x => x.cod_serial_sistemafinanceiro);
                });

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    IdSistema = table.Column<int>(type: "int", nullable: false),
                    cod_serial_categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.cod_serial_categoria);
                    table.ForeignKey(
                        name: "FK_categoria_sistemafinanceiro_IdSistema",
                        column: x => x.IdSistema,
                        principalTable: "sistemafinanceiro",
                        principalColumn: "cod_serial_sistemafinanceiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuariosistemafinanceiro",
                columns: table => new
                {
                    SistemaId = table.Column<int>(type: "int", nullable: false),
                    cod_serial_userfinacesystem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin = table.Column<bool>(type: "bit", nullable: false),
                    sistemaatual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosistemafinanceiro", x => x.cod_serial_userfinacesystem);
                    table.ForeignKey(
                        name: "FK_usuariosistemafinanceiro_sistemafinanceiro_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "sistemafinanceiro",
                        principalColumn: "cod_serial_sistemafinanceiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "despesa",
                columns: table => new
                {
                    cod_serial_despesa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mes = table.Column<int>(type: "int", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    tipodespesa = table.Column<int>(type: "int", nullable: false),
                    datacadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataalteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datapagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datavencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pago = table.Column<bool>(type: "bit", nullable: false),
                    despesaatrasada = table.Column<bool>(type: "bit", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despesa", x => x.cod_serial_despesa);
                    table.ForeignKey(
                        name: "FK_despesa_categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "categoria",
                        principalColumn: "cod_serial_categoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoria_IdSistema",
                table: "categoria",
                column: "IdSistema");

            migrationBuilder.CreateIndex(
                name: "IX_despesa_IdCategoria",
                table: "despesa",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosistemafinanceiro_SistemaId",
                table: "usuariosistemafinanceiro",
                column: "SistemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "despesa");

            migrationBuilder.DropTable(
                name: "usuariosistemafinanceiro");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "sistemafinanceiro");
        }
    }
}
