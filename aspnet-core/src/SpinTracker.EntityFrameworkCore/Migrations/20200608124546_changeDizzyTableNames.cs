using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class changeDizzyTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Bodys");

            migrationBuilder.CreateTable(
                name: "DizzyAttacks",
                columns: table => new
                {
                    DizzyAttackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vertigo = table.Column<bool>(nullable: false),
                    Drop = table.Column<bool>(nullable: false),
                    Electricity = table.Column<bool>(nullable: false),
                    VertigoIntensity = table.Column<int>(nullable: false),
                    VertigoDuration = table.Column<int>(nullable: false),
                    DropIntensity = table.Column<int>(nullable: false),
                    ElectricityIntensity = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DizzyAttacks", x => x.DizzyAttackId);
                    table.ForeignKey(
                        name: "FK_DizzyAttacks_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DizzyBodys",
                columns: table => new
                {
                    DizzyBodyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stress = table.Column<int>(nullable: false),
                    ShoulderStiffness = table.Column<int>(nullable: false),
                    Headache = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DizzyBodys", x => x.DizzyBodyId);
                    table.ForeignKey(
                        name: "FK_DizzyBodys_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DizzyAttacks_EntryDateId",
                table: "DizzyAttacks",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_DizzyBodys_EntryDateId",
                table: "DizzyBodys",
                column: "EntryDateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DizzyAttacks");

            migrationBuilder.DropTable(
                name: "DizzyBodys");

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    AttackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drop = table.Column<bool>(type: "bit", nullable: false),
                    DropIntensity = table.Column<int>(type: "int", nullable: false),
                    Electricity = table.Column<bool>(type: "bit", nullable: false),
                    ElectricityIntensity = table.Column<int>(type: "int", nullable: false),
                    EntryDateId = table.Column<int>(type: "int", nullable: false),
                    Vertigo = table.Column<bool>(type: "bit", nullable: false),
                    VertigoDuration = table.Column<int>(type: "int", nullable: false),
                    VertigoIntensity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.AttackId);
                    table.ForeignKey(
                        name: "FK_Attacks_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bodys",
                columns: table => new
                {
                    BodyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDateId = table.Column<int>(type: "int", nullable: false),
                    Headache = table.Column<int>(type: "int", nullable: false),
                    ShoulderStiffness = table.Column<int>(type: "int", nullable: false),
                    Stress = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodys", x => x.BodyId);
                    table.ForeignKey(
                        name: "FK_Bodys_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_EntryDateId",
                table: "Attacks",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodys_EntryDateId",
                table: "Bodys",
                column: "EntryDateId");
        }
    }
}
