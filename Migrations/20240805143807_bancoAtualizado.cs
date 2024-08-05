using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class bancoAtualizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "entidade",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "entidade");
        }
    }
}
