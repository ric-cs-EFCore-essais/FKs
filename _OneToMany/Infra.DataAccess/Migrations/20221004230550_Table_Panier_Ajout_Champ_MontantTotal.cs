using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DataAccess.Migrations
{
    public partial class Table_Panier_Ajout_Champ_MontantTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MontantTotal",
                table: "Paniers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontantTotal",
                table: "Paniers");
        }
    }
}
