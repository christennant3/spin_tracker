using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpinTracker.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits");

            migrationBuilder.CreateTable(
                name: "AbpDynamicParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParameterName = table.Column<string>(nullable: true),
                    InputType = table.Column<string>(nullable: true),
                    Permission = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpDynamicParameters", x => x.Id);
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
                name: "ConsumeUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumeUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntryDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEntry = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryDates_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntryDates_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealType", x => x.Id);
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
                name: "TimeOfDays",
                columns: table => new
                {
                    TimeOfDayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOfDays", x => x.TimeOfDayId);
                });

            migrationBuilder.CreateTable(
                name: "WeatherTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpDynamicParameterValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    DynamicParameterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpDynamicParameterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpDynamicParameterValues_AbpDynamicParameters_DynamicParameterId",
                        column: x => x.DynamicParameterId,
                        principalTable: "AbpDynamicParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityDynamicParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityFullName = table.Column<string>(nullable: true),
                    DynamicParameterId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityDynamicParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityDynamicParameters_AbpDynamicParameters_DynamicParameterId",
                        column: x => x.DynamicParameterId,
                        principalTable: "AbpDynamicParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkins",
                columns: table => new
                {
                    CheckinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ConditionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkins", x => x.CheckinId);
                    table.ForeignKey(
                        name: "FK_Checkins_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Water = table.Column<int>(nullable: false),
                    Alcohol = table.Column<int>(nullable: false),
                    Tobacco = table.Column<int>(nullable: false),
                    ConsumeUnitWaterId = table.Column<int>(nullable: false),
                    ConsumeUnitAlcoholId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false),
                    ConsumeUnitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumes_ConsumeUnits_ConsumeUnitId",
                        column: x => x.ConsumeUnitId,
                        principalTable: "ConsumeUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consumes_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Sleeps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SleepTime = table.Column<DateTime>(nullable: false),
                    AwakeTime = table.Column<DateTime>(nullable: false),
                    SleepQuality = table.Column<int>(nullable: false),
                    Sofa = table.Column<bool>(nullable: false),
                    FellAsleep = table.Column<bool>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sleeps_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ConditionId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
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
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salt = table.Column<int>(nullable: false),
                    Sugar = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false),
                    MealTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meals_MealType_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pollen = table.Column<string>(nullable: true),
                    Barometric = table.Column<string>(nullable: true),
                    Temperature = table.Column<int>(nullable: false),
                    WeatherTypeId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weathers_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weathers_WeatherTypes_WeatherTypeId",
                        column: x => x.WeatherTypeId,
                        principalTable: "WeatherTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityDynamicParameterValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: false),
                    EntityId = table.Column<string>(nullable: true),
                    EntityDynamicParameterId = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityDynamicParameterValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityDynamicParameterValues_AbpEntityDynamicParameters_EntityDynamicParameterId",
                        column: x => x.EntityDynamicParameterId,
                        principalTable: "AbpEntityDynamicParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckinScores",
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
                    table.PrimaryKey("PK_CheckinScores", x => x.CheckinScoreId);
                    table.ForeignKey(
                        name: "FK_CheckinScores_Checkins_CheckinId",
                        column: x => x.CheckinId,
                        principalTable: "Checkins",
                        principalColumn: "CheckinId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckinScores_EntryDates_EntryDateId",
                        column: x => x.EntryDateId,
                        principalTable: "EntryDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckinScores_TimeOfDays_TimeOfDayId",
                        column: x => x.TimeOfDayId,
                        principalTable: "TimeOfDays",
                        principalColumn: "TimeOfDayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentActives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    TreatmentActivesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentActives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreatmentActives_TreatmentActives_TreatmentActivesId",
                        column: x => x.TreatmentActivesId,
                        principalTable: "TreatmentActives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TreatmentActives_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Completed = table.Column<bool>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    EntryDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentResults", x => x.Id);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                columns: new[] { "TenantId", "Code" },
                unique: true,
                filter: "[TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpDynamicParameters_ParameterName_TenantId",
                table: "AbpDynamicParameters",
                columns: new[] { "ParameterName", "TenantId" },
                unique: true,
                filter: "[ParameterName] IS NOT NULL AND [TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpDynamicParameterValues_DynamicParameterId",
                table: "AbpDynamicParameterValues",
                column: "DynamicParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameters_DynamicParameterId",
                table: "AbpEntityDynamicParameters",
                column: "DynamicParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameters_EntityFullName_DynamicParameterId_TenantId",
                table: "AbpEntityDynamicParameters",
                columns: new[] { "EntityFullName", "DynamicParameterId", "TenantId" },
                unique: true,
                filter: "[EntityFullName] IS NOT NULL AND [TenantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameterValues_EntityDynamicParameterId",
                table: "AbpEntityDynamicParameterValues",
                column: "EntityDynamicParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkins_ConditionId",
                table: "Checkins",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScores_CheckinId",
                table: "CheckinScores",
                column: "CheckinId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScores_EntryDateId",
                table: "CheckinScores",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckinScores_TimeOfDayId",
                table: "CheckinScores",
                column: "TimeOfDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumes_ConsumeUnitId",
                table: "Consumes",
                column: "ConsumeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumes_EntryDateId",
                table: "Consumes",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_DizzyAttacks_EntryDateId",
                table: "DizzyAttacks",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_DizzyBodys_EntryDateId",
                table: "DizzyBodys",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryDates_EntryDateId",
                table: "EntryDates",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryDates_UserId",
                table: "EntryDates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_EntryDateId",
                table: "Exercises",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_EntryDateId",
                table: "Meals",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealTypeId",
                table: "Meals",
                column: "MealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_EntryDateId",
                table: "Medications",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EntryDateId",
                table: "Notes",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Sleeps_EntryDateId",
                table: "Sleeps",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_EntryDateId",
                table: "Supplements",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentActives_TreatmentActivesId",
                table: "TreatmentActives",
                column: "TreatmentActivesId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_EntryDateId",
                table: "Weathers",
                column: "EntryDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_WeatherTypeId",
                table: "Weathers",
                column: "WeatherTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpDynamicParameterValues");

            migrationBuilder.DropTable(
                name: "AbpEntityDynamicParameterValues");

            migrationBuilder.DropTable(
                name: "CheckinScores");

            migrationBuilder.DropTable(
                name: "Consumes");

            migrationBuilder.DropTable(
                name: "DizzyAttacks");

            migrationBuilder.DropTable(
                name: "DizzyBodys");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "MedicationLists");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Sleeps");

            migrationBuilder.DropTable(
                name: "SupplementLists");

            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropTable(
                name: "TreatmentActives");

            migrationBuilder.DropTable(
                name: "TreatmentResults");

            migrationBuilder.DropTable(
                name: "Weathers");

            migrationBuilder.DropTable(
                name: "AbpEntityDynamicParameters");

            migrationBuilder.DropTable(
                name: "Checkins");

            migrationBuilder.DropTable(
                name: "TimeOfDays");

            migrationBuilder.DropTable(
                name: "ConsumeUnits");

            migrationBuilder.DropTable(
                name: "MealType");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "WeatherTypes");

            migrationBuilder.DropTable(
                name: "AbpDynamicParameters");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "EntryDates");

            migrationBuilder.DropIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                columns: new[] { "TenantId", "Code" });
        }
    }
}
