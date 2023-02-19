using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseManger.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MainDivisionId = table.Column<int>(type: "INTEGER", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Divisions_MainDivisionId",
                        column: x => x.MainDivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainDataBaseVerison",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Verison = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainDataBaseVerison", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectScoreRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PassMin = table.Column<int>(type: "INTEGER", nullable: false),
                    Good = table.Column<int>(type: "INTEGER", nullable: false),
                    VeryGood = table.Column<int>(type: "INTEGER", nullable: false),
                    Excellent = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectScoreRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NID = table.Column<string>(type: "TEXT", maxLength: 14, nullable: true),
                    Pass = table.Column<string>(type: "TEXT", nullable: true),
                    MustChangePass = table.Column<bool>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanLogin = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsLogin = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserAccess = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionDivisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DivisionId = table.Column<int>(type: "INTEGER", nullable: true),
                    EducationalInstitutionId = table.Column<int>(type: "INTEGER", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionDivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionDivisions_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstitutionDivisions_EducationalInstitutions_EducationalInstitutionId",
                        column: x => x.EducationalInstitutionId,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SubjectScoreRateId = table.Column<int>(type: "INTEGER", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectScoreRates_SubjectScoreRateId",
                        column: x => x.SubjectScoreRateId,
                        principalTable: "SubjectScoreRates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TargetClass = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    Action = table.Column<int>(type: "INTEGER", nullable: false),
                    MainDataBaseVerisonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataLog_MainDataBaseVerison_MainDataBaseVerisonId",
                        column: x => x.MainDataBaseVerisonId,
                        principalTable: "MainDataBaseVerison",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataLog_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjectMangeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddId = table.Column<int>(type: "INTEGER", nullable: true),
                    AddSupportId = table.Column<int>(type: "INTEGER", nullable: true),
                    AddDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConfermId = table.Column<int>(type: "INTEGER", nullable: true),
                    ConfermSupportId = table.Column<int>(type: "INTEGER", nullable: true),
                    ConferdDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubjectScoreType = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjectMangeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMangeds_Users_AddId",
                        column: x => x.AddId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMangeds_Users_AddSupportId",
                        column: x => x.AddSupportId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMangeds_Users_ConfermId",
                        column: x => x.ConfermId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMangeds_Users_ConfermSupportId",
                        column: x => x.ConfermSupportId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionDivisionUser",
                columns: table => new
                {
                    InstitutionDivisionsId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionDivisionUser", x => new { x.InstitutionDivisionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_InstitutionDivisionUser_InstitutionDivisions_InstitutionDivisionsId",
                        column: x => x.InstitutionDivisionsId,
                        principalTable: "InstitutionDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstitutionDivisionUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<uint>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<uint>(type: "INTEGER", nullable: false),
                    InstitutionDivisionId = table.Column<int>(type: "INTEGER", nullable: true),
                    Stat = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_InstitutionDivisions_InstitutionDivisionId",
                        column: x => x.InstitutionDivisionId,
                        principalTable: "InstitutionDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DivisionSubject",
                columns: table => new
                {
                    DivisionsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionSubject", x => new { x.DivisionsId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_DivisionSubject_Divisions_DivisionsId",
                        column: x => x.DivisionsId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DivisionSubject_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MinimumScore = table.Column<uint>(type: "INTEGER", nullable: false),
                    MaximumScore = table.Column<uint>(type: "INTEGER", nullable: false),
                    ScoreType = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectScores_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjectScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<uint>(type: "INTEGER", nullable: false),
                    ScoreType = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: true),
                    Confirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    StudentSubjectStat = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentSubjectMangedId = table.Column<int>(type: "INTEGER", nullable: true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjectScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjectScores_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectScores_StudentSubjectMangeds_StudentSubjectMangedId",
                        column: x => x.StudentSubjectMangedId,
                        principalTable: "StudentSubjectMangeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectScores_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataLog_MainDataBaseVerisonId",
                table: "DataLog",
                column: "MainDataBaseVerisonId");

            migrationBuilder.CreateIndex(
                name: "IX_DataLog_UserId",
                table: "DataLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_MainDivisionId",
                table: "Divisions",
                column: "MainDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_DivisionSubject_SubjectsId",
                table: "DivisionSubject",
                column: "SubjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionDivisions_DivisionId",
                table: "InstitutionDivisions",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionDivisions_EducationalInstitutionId",
                table: "InstitutionDivisions",
                column: "EducationalInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionDivisionUser_UsersId",
                table: "InstitutionDivisionUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InstitutionDivisionId",
                table: "Students",
                column: "InstitutionDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMangeds_AddId",
                table: "StudentSubjectMangeds",
                column: "AddId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMangeds_AddSupportId",
                table: "StudentSubjectMangeds",
                column: "AddSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMangeds_ConfermId",
                table: "StudentSubjectMangeds",
                column: "ConfermId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMangeds_ConfermSupportId",
                table: "StudentSubjectMangeds",
                column: "ConfermSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectScores_StudentId",
                table: "StudentSubjectScores",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectScores_StudentSubjectMangedId",
                table: "StudentSubjectScores",
                column: "StudentSubjectMangedId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectScores_SubjectId",
                table: "StudentSubjectScores",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectScoreRateId",
                table: "Subjects",
                column: "SubjectScoreRateId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectScores_SubjectId",
                table: "SubjectScores",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataLog");

            migrationBuilder.DropTable(
                name: "DivisionSubject");

            migrationBuilder.DropTable(
                name: "InstitutionDivisionUser");

            migrationBuilder.DropTable(
                name: "StudentSubjectScores");

            migrationBuilder.DropTable(
                name: "SubjectScores");

            migrationBuilder.DropTable(
                name: "MainDataBaseVerison");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentSubjectMangeds");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "InstitutionDivisions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubjectScoreRates");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "EducationalInstitutions");
        }
    }
}
