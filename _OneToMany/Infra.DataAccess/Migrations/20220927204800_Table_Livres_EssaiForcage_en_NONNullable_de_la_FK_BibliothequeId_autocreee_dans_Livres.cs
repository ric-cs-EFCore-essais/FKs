using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DataAccess.Migrations
{
    public partial class Table_Livres_EssaiForcage_en_NONNullable_de_la_FK_BibliothequeId_autocreee_dans_Livres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livres_Bibliotheques_BibliothequeId",
                table: "Livres");

            migrationBuilder.AlterColumn<int>(
                name: "BibliothequeId",
                table: "Livres",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Livres_Bibliotheques_BibliothequeId",
                table: "Livres",
                column: "BibliothequeId",
                principalTable: "Bibliotheques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livres_Bibliotheques_BibliothequeId",
                table: "Livres");

            migrationBuilder.AlterColumn<int>(
                name: "BibliothequeId",
                table: "Livres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Livres_Bibliotheques_BibliothequeId",
                table: "Livres",
                column: "BibliothequeId",
                principalTable: "Bibliotheques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
