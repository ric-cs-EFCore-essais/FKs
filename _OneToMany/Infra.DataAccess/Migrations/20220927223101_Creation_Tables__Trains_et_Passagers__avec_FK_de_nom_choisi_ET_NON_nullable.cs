using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.DataAccess.Migrations
{
    public partial class Creation_Tables__Trains_et_Passagers__avec_FK_de_nom_choisi_ET_NON_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroSecu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    My_TrainId_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passagers_Trains_My_TrainId_FK",
                        column: x => x.My_TrainId_FK,
                        principalTable: "Trains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagers_My_TrainId_FK",
                table: "Passagers",
                column: "My_TrainId_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passagers");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
