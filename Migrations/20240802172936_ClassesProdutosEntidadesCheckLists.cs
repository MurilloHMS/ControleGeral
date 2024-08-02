using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class ClassesProdutosEntidadesCheckLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_Empresa",
                table: "veiculos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotaFiscalDeCompra",
                table: "veiculos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoVeiculo",
                table: "veiculos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "checklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checklist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dadosCheckLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID_Veiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_Item = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_NotaFiscal = table.Column<int>(type: "INTEGER", nullable: true),
                    KmRodados = table.Column<int>(type: "INTEGER", nullable: true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ID_Concessionaria = table.Column<int>(type: "INTEGER", nullable: false),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dadosCheckLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "dadosNFe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID_Veiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    ChaveDeAcesso = table.Column<string>(type: "TEXT", nullable: false),
                    NumNFe = table.Column<string>(type: "TEXT", nullable: false),
                    Serie = table.Column<string>(type: "TEXT", nullable: false),
                    RazaoSocialRemetente = table.Column<string>(type: "TEXT", nullable: false),
                    CNPJRemetente = table.Column<string>(type: "TEXT", nullable: false),
                    RazaoSocialDestinatario = table.Column<string>(type: "TEXT", nullable: false),
                    CNPJDestinatario = table.Column<string>(type: "TEXT", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataRevisao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NaturezaOperacao = table.Column<string>(type: "TEXT", nullable: false),
                    ValorTotalProdutos = table.Column<double>(type: "REAL", nullable: false),
                    ValorTotalNotaFiscal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dadosNFe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "entidade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<string>(type: "TEXT", nullable: true),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: true),
                    Complemento = table.Column<string>(type: "TEXT", nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", nullable: true),
                    Localidade = table.Column<string>(type: "TEXT", nullable: true),
                    Uf = table.Column<string>(type: "TEXT", nullable: true),
                    Ibge = table.Column<string>(type: "TEXT", nullable: true),
                    Gia = table.Column<string>(type: "TEXT", nullable: true),
                    Ddd = table.Column<string>(type: "TEXT", nullable: true),
                    Siafi = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    Concessionaria_CNPJ = table.Column<string>(type: "TEXT", nullable: true),
                    Concessionaria_IE = table.Column<string>(type: "TEXT", nullable: true),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: true),
                    IE = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID_NFe = table.Column<int>(type: "INTEGER", nullable: true),
                    ID_Veiculo = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroNFe = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoProduto = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorUnitario = table.Column<double>(type: "REAL", nullable: true),
                    ValorTotal = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checklist");

            migrationBuilder.DropTable(
                name: "dadosCheckLists");

            migrationBuilder.DropTable(
                name: "dadosNFe");

            migrationBuilder.DropTable(
                name: "entidade");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropColumn(
                name: "ID_Empresa",
                table: "veiculos");

            migrationBuilder.DropColumn(
                name: "NotaFiscalDeCompra",
                table: "veiculos");

            migrationBuilder.DropColumn(
                name: "TipoVeiculo",
                table: "veiculos");
        }
    }
}
