using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class CadastroVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "veiculos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    KmRodados = table.Column<int>(type: "INTEGER", nullable: true),
                    DataDaCompra = table.Column<DateTime>(type: "TEXT", nullable: true),
                    KmQuandoComprado = table.Column<int>(type: "INTEGER", nullable: true),
                    Ano = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    DataUltimaRevisao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    KmUltimaRevisao = table.Column<int>(type: "INTEGER", nullable: true),
                    DataProximaRevisao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    KmProximaRevisao = table.Column<int>(type: "INTEGER", nullable: true),
                    ID_Concessionaria = table.Column<int>(type: "INTEGER", nullable: true),
                    Motorista = table.Column<string>(type: "TEXT", nullable: true),
                    SugestaoConcessionaria = table.Column<string>(type: "TEXT", nullable: true),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: true),
                    LocalSalvamentoDeDados = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculos", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "veiculos");
        }
    }
}
