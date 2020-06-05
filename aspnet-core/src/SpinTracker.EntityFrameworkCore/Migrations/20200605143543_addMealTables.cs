using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class addMealTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FellAsleep",
                table: "Sleeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sofa",
                table: "Sleeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "MealType",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealType", x => x.MealTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    Salt = table.Column<int>(nullable: false),
                    Sugar = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false),
                    MealTypeId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealTypeId);
                    table.ForeignKey(
                        name: "FK_Meals_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meals_MealType_MealTypeId1",
                        column: x => x.MealTypeId1,
                        principalTable: "MealType",
                        principalColumn: "MealTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_EntryDateId",
                table: "Meals",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealTypeId1",
                table: "Meals",
                column: "MealTypeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "MealType");

            migrationBuilder.DropColumn(
                name: "FellAsleep",
                table: "Sleeps");

            migrationBuilder.DropColumn(
                name: "Sofa",
                table: "Sleeps");
        }
    }
}
