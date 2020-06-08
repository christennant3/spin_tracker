using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class checkInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntryDateId",
                table: "EntryDates",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    CheckinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ConditionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.CheckinId);
                    table.ForeignKey(
                        name: "FK_Checkin_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeOfDay",
                columns: table => new
                {
                    TimeOfDayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOfDay", x => x.TimeOfDayId);
                });

            migrationBuilder.CreateTable(
                name: "CheckinScore",
                columns: table => new
                {
                    CheckinScoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<string>(nullable: true),
                    CheckinId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false),
                    TimeOfDayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckinScore", x => x.CheckinScoreId);
                    table.ForeignKey(
                        name: "FK_CheckinScore_Checkin_CheckinId",
                        column: x => x.CheckinId,
                        principalTable: "Checkin",
                        principalColumn: "CheckinId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckinScore_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckinScore_TimeOfDay_TimeOfDayId",
                        column: x => x.TimeOfDayId,
                        principalTable: "TimeOfDay",
                        principalColumn: "TimeOfDayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntryDates_EntryDateId",
                table: "EntryDates",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_ConditionId",
                table: "Checkin",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScore_CheckinId",
                table: "CheckinScore",
                column: "CheckinId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScore_EntryDateId",
                table: "CheckinScore",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScore_TimeOfDayId",
                table: "CheckinScore",
                column: "TimeOfDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryDates_EntryDates_EntryDateId",
                table: "EntryDates",
                column: "EntryDateId",
                principalTable: "EntryDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryDates_EntryDates_EntryDateId",
                table: "EntryDates");

            migrationBuilder.DropTable(
                name: "CheckinScore");

            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "TimeOfDay");

            migrationBuilder.DropIndex(
                name: "IX_EntryDates_EntryDateId",
                table: "EntryDates");

            migrationBuilder.DropColumn(
                name: "EntryDateId",
                table: "EntryDates");
        }
    }
}
