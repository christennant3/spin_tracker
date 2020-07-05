using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class fixEntryDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryDates_EntryDates_EntryDateId",
                table: "EntryDates");

            migrationBuilder.DropIndex(
                name: "IX_EntryDates_EntryDateId",
                table: "EntryDates");

            migrationBuilder.DropColumn(
                name: "EntryDateId",
                table: "EntryDates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntryDateId",
                table: "EntryDates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntryDates_EntryDateId",
                table: "EntryDates",
                column: "EntryDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryDates_EntryDates_EntryDateId",
                table: "EntryDates",
                column: "EntryDateId",
                principalTable: "EntryDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
