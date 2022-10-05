using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DataAccess.Migrations
{
    public partial class MiseDeQqChamps_En_UNIQUE_cad_SansDoublon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroSecu",
                table: "Passagers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Garages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_Immatric",
                table: "Voitures",
                column: "Immatric",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passagers_NumeroSecu",
                table: "Passagers",
                column: "NumeroSecu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Garages_Nom",
                table: "Garages",
                column: "Nom",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Voitures_Immatric",
                table: "Voitures");

            migrationBuilder.DropIndex(
                name: "IX_Passagers_NumeroSecu",
                table: "Passagers");

            migrationBuilder.DropIndex(
                name: "IX_Garages_Nom",
                table: "Garages");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroSecu",
                table: "Passagers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Garages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
