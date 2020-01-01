using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InternshipAssignment.Data.Migrations
{
    public partial class version_one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptName = table.Column<string>(maxLength: 150, nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "GenderModel",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    GenderName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderModel", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    LanguageName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    MaritalStatusName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    ReligionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    ReligionName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "CvModel",
                columns: table => new
                {
                    CvId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcademicQualification = table.Column<string>(maxLength: 2000, nullable: false),
                    CareerObjective = table.Column<string>(maxLength: 2000, nullable: false),
                    CurrentAddress = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DeptId = table.Column<int>(nullable: false),
                    EmailOne = table.Column<string>(nullable: false),
                    EmailTwo = table.Column<string>(nullable: false),
                    ExtraCurricularFive = table.Column<string>(maxLength: 2000, nullable: true),
                    ExtraCurricularFour = table.Column<string>(maxLength: 2000, nullable: true),
                    ExtraCurricularOne = table.Column<string>(maxLength: 2000, nullable: true),
                    ExtraCurricularThree = table.Column<string>(maxLength: 2000, nullable: true),
                    ExtraCurricularTwo = table.Column<string>(maxLength: 2000, nullable: true),
                    FatherName = table.Column<string>(maxLength: 50, nullable: false),
                    FieldOfInterest = table.Column<string>(maxLength: 2000, nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    LanguageThree = table.Column<string>(maxLength: 100, nullable: true),
                    LanguageTwo = table.Column<string>(maxLength: 100, nullable: true),
                    MaritalStatusId = table.Column<int>(nullable: false),
                    MotherName = table.Column<string>(maxLength: 50, nullable: false),
                    NIDNumber = table.Column<string>(maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(maxLength: 100, nullable: false),
                    PermanentAddress = table.Column<string>(maxLength: 1000, nullable: false),
                    PhoneOne = table.Column<string>(nullable: false),
                    PhoneTwo = table.Column<string>(nullable: false),
                    PositionOne = table.Column<string>(maxLength: 500, nullable: false),
                    PositionTwo = table.Column<string>(maxLength: 500, nullable: false),
                    ProfileImage = table.Column<byte[]>(nullable: false),
                    ProjectContentFive = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectContentFour = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectContentOne = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectContentThree = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectContentTwo = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectNameFive = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectNameFour = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectNameOne = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectNameThree = table.Column<string>(maxLength: 2000, nullable: true),
                    ProjectNameTwo = table.Column<string>(maxLength: 2000, nullable: true),
                    ReligionId = table.Column<int>(nullable: false),
                    TeacherNameOne = table.Column<string>(maxLength: 100, nullable: false),
                    TeacherNameTwo = table.Column<string>(maxLength: 100, nullable: false),
                    TechnicalSkillContentFive = table.Column<string>(maxLength: 2000, nullable: true),
                    TechnicalSkillContentFour = table.Column<string>(maxLength: 2000, nullable: true),
                    TechnicalSkillContentOne = table.Column<string>(maxLength: 2000, nullable: true),
                    TechnicalSkillContentThree = table.Column<string>(maxLength: 2000, nullable: true),
                    TechnicalSkillContentTwo = table.Column<string>(maxLength: 2000, nullable: true),
                    TechnicalSkillTitleFive = table.Column<string>(maxLength: 200, nullable: true),
                    TechnicalSkillTitleFour = table.Column<string>(maxLength: 200, nullable: true),
                    TechnicalSkillTitleOne = table.Column<string>(maxLength: 200, nullable: true),
                    TechnicalSkillTitleThree = table.Column<string>(maxLength: 200, nullable: true),
                    TechnicalSkillTitleTwo = table.Column<string>(maxLength: 200, nullable: true),
                    UniversityName = table.Column<string>(maxLength: 200, nullable: false),
                    YourEmail = table.Column<string>(nullable: false),
                    YourName = table.Column<string>(maxLength: 50, nullable: false),
                    YourPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvModel", x => x.CvId);
                    table.ForeignKey(
                        name: "FK_CvModel_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvModel_GenderModel_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderModel",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvModel_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvModel_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "MaritalStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvModel_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CvModel_DeptId",
                table: "CvModel",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_CvModel_GenderId",
                table: "CvModel",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CvModel_LanguageId",
                table: "CvModel",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CvModel_MaritalStatusId",
                table: "CvModel",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CvModel_ReligionId",
                table: "CvModel",
                column: "ReligionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CvModel");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "GenderModel");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
