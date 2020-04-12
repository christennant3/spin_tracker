using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class weathertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherId = table.Column<int>(nullable: false),
                    Pollen = table.Column<string>(nullable: true),
                    Barometric = table.Column<string>(nullable: true),
                    Temperature = table.Column<int>(nullable: false),
                    WeatherTypeId = table.Column<int>(nullable: false),
                    WeatherConditionsTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
