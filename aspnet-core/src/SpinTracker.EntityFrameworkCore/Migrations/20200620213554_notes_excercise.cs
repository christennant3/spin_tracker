using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class notes_excercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentActives_Treatments_TreatmentId",
                table: "TreatmentActives");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentResults_Treatments_TreatmentId",
                table: "TreatmentResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentResults",
                table: "TreatmentResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentActives",
                table: "TreatmentActives");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentActives_TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives");

            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "TreatmentResultId",
                table: "TreatmentResults");

            migrationBuilder.DropColumn(
                name: "TreatmentActiveId",
                table: "TreatmentActives");

            migrationBuilder.DropColumn(
                name: "TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Treatments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TreatmentResults",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TreatmentActives",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentActivesId",
                table: "TreatmentActives",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentResults",
                table: "TreatmentResults",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentActives",
                table: "TreatmentActives",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseType = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_TreatmentActivesId",
                table: "TreatmentActives",
                column: "TreatmentActivesId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_EntryDateId",
                table: "Exercises",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EntryDateId",
                table: "Notes",
                column: "EntryDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesId",
                table: "TreatmentActives",
                column: "TreatmentActivesId",
                principalTable: "TreatmentActives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentActives_Treatments_TreatmentId",
                table: "TreatmentActives",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentResults_Treatments_TreatmentId",
                table: "TreatmentResults",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesId",
                table: "TreatmentActives");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentActives_Treatments_TreatmentId",
                table: "TreatmentActives");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentResults_Treatments_TreatmentId",
                table: "TreatmentResults");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentResults",
                table: "TreatmentResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreatmentActives",
                table: "TreatmentActives");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentActives_TreatmentActivesId",
                table: "TreatmentActives");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TreatmentResults");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TreatmentActives");

            migrationBuilder.DropColumn(
                name: "TreatmentActivesId",
                table: "TreatmentActives");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentId",
                table: "Treatments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentResultId",
                table: "TreatmentResults",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentActiveId",
                table: "TreatmentActives",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments",
                column: "TreatmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentResults",
                table: "TreatmentResults",
                column: "TreatmentResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreatmentActives",
                table: "TreatmentActives",
                column: "TreatmentActiveId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives",
                column: "TreatmentActivesTreatmentActiveId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives",
                column: "TreatmentActivesTreatmentActiveId",
                principalTable: "TreatmentActives",
                principalColumn: "TreatmentActiveId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentActives_Treatments_TreatmentId",
                table: "TreatmentActives",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "TreatmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentResults_Treatments_TreatmentId",
                table: "TreatmentResults",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "TreatmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
