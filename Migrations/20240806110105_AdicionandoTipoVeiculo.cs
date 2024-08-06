using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTipoVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusVeiculo",
                table: "veiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVeiculo",
                table: "veiculos");
        }
    }
}
