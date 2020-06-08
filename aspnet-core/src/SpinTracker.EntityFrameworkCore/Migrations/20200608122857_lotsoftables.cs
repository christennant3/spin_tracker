using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class lotsoftables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    AttackId = table.Column<int>(nullable: false)
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
                    BodyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stress = table.Column<int>(nullable: false),
                    ShoulderStiffness = table.Column<int>(nullable: false),
                    Headache = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "MedicationLists",
                columns: table => new
                {
                    MedicationListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationLists", x => x.MedicationListId);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    MedicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.MedicationId);
                    table.ForeignKey(
                        name: "FK_Medications_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplementLists",
                columns: table => new
                {
                    SupplementListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplementLists", x => x.SupplementListId);
                });

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    SupplementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.SupplementId);
                    table.ForeignKey(
                        name: "FK_Supplements_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ConditionId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentId);
                    table.ForeignKey(
                        name: "FK_Treatments_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentActives",
                columns: table => new
                {
                    TreatmentActiveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    TreatmentActivesTreatmentActiveId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentActives", x => x.TreatmentActiveId);
                    table.ForeignKey(
                        name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesTreatmentActiveId",
                        column: x => x.TreatmentActivesTreatmentActiveId,
                        principalTable: "TreatmentActives",
                        principalColumn: "TreatmentActiveId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TreatmentActives_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreatmentActives_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentResults",
                columns: table => new
                {
                    TreatmentResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Completed = table.Column<bool>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentResults", x => x.TreatmentResultId);
                    table.ForeignKey(
                        name: "FK_TreatmentResults_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreatmentResults_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Medications_EntryDateId",
                table: "Medications",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_EntryDateId",
                table: "Supplements",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_TreatmentActivesTreatmentActiveId",
                table: "TreatmentActives",
                column: "TreatmentActivesTreatmentActiveId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_TreatmentId",
                table: "TreatmentActives",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_UserId",
                table: "TreatmentActives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentResults_EntryDateId",
                table: "TreatmentResults",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentResults_TreatmentId",
                table: "TreatmentResults",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_ConditionId",
                table: "Treatments",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_EntryDateId",
                table: "Treatments",
                column: "EntryDateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Bodys");

            migrationBuilder.DropTable(
                name: "MedicationLists");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "SupplementLists");

            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropTable(
                name: "TreatmentActives");

            migrationBuilder.DropTable(
                name: "TreatmentResults");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Conditions");
        }
    }
}
