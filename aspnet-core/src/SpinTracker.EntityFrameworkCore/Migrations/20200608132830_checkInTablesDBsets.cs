using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class checkInTablesDBsets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkin_Conditions_ConditionId",
                table: "Checkin");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckinScore_Checkin_CheckinId",
                table: "CheckinScore");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckinScore_EntryDates_EntryDateId",
                table: "CheckinScore");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckinScore_TimeOfDay_TimeOfDayId",
                table: "CheckinScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeOfDay",
                table: "TimeOfDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckinScore",
                table: "CheckinScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkin",
                table: "Checkin");

            migrationBuilder.RenameTable(
                name: "TimeOfDay",
                newName: "TimeOfDays");

            migrationBuilder.RenameTable(
                name: "CheckinScore",
                newName: "checkinScores");

            migrationBuilder.RenameTable(
                name: "Checkin",
                newName: "Checkins");

            migrationBuilder.RenameIndex(
                name: "IX_CheckinScore_TimeOfDayId",
                table: "checkinScores",
                newName: "IX_checkinScores_TimeOfDayId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckinScore_EntryDateId",
                table: "checkinScores",
                newName: "IX_checkinScores_EntryDateId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckinScore_CheckinId",
                table: "checkinScores",
                newName: "IX_checkinScores_CheckinId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkin_ConditionId",
                table: "Checkins",
                newName: "IX_Checkins_ConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeOfDays",
                table: "TimeOfDays",
                column: "TimeOfDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_checkinScores",
                table: "checkinScores",
                column: "CheckinScoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkins",
                table: "Checkins",
                column: "CheckinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkins_Conditions_ConditionId",
                table: "Checkins",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "ConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_checkinScores_Checkins_CheckinId",
                table: "checkinScores",
                column: "CheckinId",
                principalTable: "Checkins",
                principalColumn: "CheckinId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_checkinScores_EntryDates_EntryDateId",
                table: "checkinScores",
                column: "EntryDateId",
                principalTable: "EntryDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_checkinScores_TimeOfDays_TimeOfDayId",
                table: "checkinScores",
                column: "TimeOfDayId",
                principalTable: "TimeOfDays",
                principalColumn: "TimeOfDayId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkins_Conditions_ConditionId",
                table: "Checkins");

            migrationBuilder.DropForeignKey(
                name: "FK_checkinScores_Checkins_CheckinId",
                table: "checkinScores");

            migrationBuilder.DropForeignKey(
                name: "FK_checkinScores_EntryDates_EntryDateId",
                table: "checkinScores");

            migrationBuilder.DropForeignKey(
                name: "FK_checkinScores_TimeOfDays_TimeOfDayId",
                table: "checkinScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeOfDays",
                table: "TimeOfDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_checkinScores",
                table: "checkinScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkins",
                table: "Checkins");

            migrationBuilder.RenameTable(
                name: "TimeOfDays",
                newName: "TimeOfDay");

            migrationBuilder.RenameTable(
                name: "checkinScores",
                newName: "CheckinScore");

            migrationBuilder.RenameTable(
                name: "Checkins",
                newName: "Checkin");

            migrationBuilder.RenameIndex(
                name: "IX_checkinScores_TimeOfDayId",
                table: "CheckinScore",
                newName: "IX_CheckinScore_TimeOfDayId");

            migrationBuilder.RenameIndex(
                name: "IX_checkinScores_EntryDateId",
                table: "CheckinScore",
                newName: "IX_CheckinScore_EntryDateId");

            migrationBuilder.RenameIndex(
                name: "IX_checkinScores_CheckinId",
                table: "CheckinScore",
                newName: "IX_CheckinScore_CheckinId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkins_ConditionId",
                table: "Checkin",
                newName: "IX_Checkin_ConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeOfDay",
                table: "TimeOfDay",
                column: "TimeOfDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckinScore",
                table: "CheckinScore",
                column: "CheckinScoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkin",
                table: "Checkin",
                column: "CheckinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkin_Conditions_ConditionId",
                table: "Checkin",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "ConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckinScore_Checkin_CheckinId",
                table: "CheckinScore",
                column: "CheckinId",
                principalTable: "Checkin",
                principalColumn: "CheckinId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckinScore_EntryDates_EntryDateId",
                table: "CheckinScore",
                column: "EntryDateId",
                principalTable: "EntryDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckinScore_TimeOfDay_TimeOfDayId",
                table: "CheckinScore",
                column: "TimeOfDayId",
                principalTable: "TimeOfDay",
                principalColumn: "TimeOfDayId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
