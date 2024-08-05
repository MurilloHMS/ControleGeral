using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoDadosCkechList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DadosCheckListID",
                table: "checklist",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_checklist_DadosCheckListID",
                table: "checklist",
                column: "DadosCheckListID");

            migrationBuilder.AddForeignKey(
                name: "FK_checklist_dadosCheckLists_DadosCheckListID",
                table: "checklist",
                column: "DadosCheckListID",
                principalTable: "dadosCheckLists",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_checklist_dadosCheckLists_DadosCheckListID",
                table: "checklist");

            migrationBuilder.DropIndex(
                name: "IX_checklist_DadosCheckListID",
                table: "checklist");

            migrationBuilder.DropColumn(
                name: "DadosCheckListID",
                table: "checklist");
        }
    }
}
