using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DataAccess.Migrations
{
    public partial class Creation_Tables__Voitures_et_Garages__avec_FK_demblee_NON_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voitures",
                columns: table => new
                {
                    Immatric = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GarageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voitures", x => x.Immatric);
                    table.ForeignKey(
                        name: "FK_Voitures_Garages_GarageId",
                        column: x => x.GarageId,
                        principalTable: "Garages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_GarageId",
                table: "Voitures",
                column: "GarageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voitures");

            migrationBuilder.DropTable(
                name: "Garages");
        }
    }
}
