using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhoraControl.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaoDadosChecklistAceitarJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_checklist_dadosCheckLists_DadosCheckListID",
                table: "checklist");

            migrationBuilder.DropIndex(
                name: "IX_checklist_DadosCheckListID",
                table: "checklist");

            migrationBuilder.DropColumn(
                name: "ID_Item",
                table: "dadosCheckLists");

            migrationBuilder.DropColumn(
                name: "DadosCheckListID",
                table: "checklist");

            migrationBuilder.AddColumn<string>(
                name: "ChecklistJson",
                table: "dadosCheckLists",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ValorRevisao",
                table: "dadosCheckLists",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChecklistJson",
                table: "dadosCheckLists");

            migrationBuilder.DropColumn(
                name: "ValorRevisao",
                table: "dadosCheckLists");

            migrationBuilder.AddColumn<int>(
                name: "ID_Item",
                table: "dadosCheckLists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DadosCheckListID",
                table: "checklist",
                type: "integer",
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
    }
}
