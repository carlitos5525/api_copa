using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaobId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaobId",
                table: "Jogos",
                newName: "SelecaoBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaobId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaoBId",
                table: "Jogos",
                newName: "SelecaobId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaobId",
                table: "Jogos",
                column: "SelecaobId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
