using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class fixDoubleId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeatherTypeId",
                table: "WeatherTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeatherTypeId",
                table: "WeatherTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
