using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionSystem.Migrations
{
    public partial class migrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecord_StudentDetials_StudentDetialsID",
                table: "AcademicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationList_StudentDetials_StudentDetialsID",
                table: "ApplicationList");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_StudentDetials_StudentDetialsID",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "StudentDetials");

            migrationBuilder.RenameColumn(
                name: "StudentDetialsID",
                table: "Documents",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_StudentDetialsID",
                table: "Documents",
                newName: "IX_Documents_StudentID");

            migrationBuilder.RenameColumn(
                name: "StudentDetialsID",
                table: "ApplicationList",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationList_StudentDetialsID",
                table: "ApplicationList",
                newName: "IX_ApplicationList_StudentID");

            migrationBuilder.RenameColumn(
                name: "StudentDetialsID",
                table: "AcademicRecord",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicRecord_StudentDetialsID",
                table: "AcademicRecord",
                newName: "IX_AcademicRecord_StudentID");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(maxLength: 60, nullable: false),
                    StudentAddress = table.Column<string>(maxLength: 500, nullable: false),
                    City = table.Column<string>(maxLength: 25, nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 25, nullable: false),
                    Nationality = table.Column<string>(maxLength: 25, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    StudentGuradianName = table.Column<string>(maxLength: 30, nullable: false),
                    RelWithGuardian = table.Column<string>(nullable: false),
                    BloodGroup = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ResidencePhone = table.Column<string>(nullable: true),
                    PlaceOfBirth = table.Column<string>(maxLength: 25, nullable: false),
                    GuardianMobileNumber = table.Column<string>(nullable: false),
                    ApplicantsMobileNumber = table.Column<string>(nullable: false),
                    FamilyIncome = table.Column<decimal>(nullable: false),
                    StudentSignature = table.Column<string>(nullable: false),
                    StudentPhoto = table.Column<string>(nullable: false),
                    AadharNumber = table.Column<string>(nullable: true),
                    Caste = table.Column<int>(nullable: true),
                    GuradianOccupation = table.Column<string>(maxLength: 20, nullable: true),
                    PHStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecord_Student_StudentID",
                table: "AcademicRecord",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationList_Student_StudentID",
                table: "ApplicationList",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Student_StudentID",
                table: "Documents",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecord_Student_StudentID",
                table: "AcademicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationList_Student_StudentID",
                table: "ApplicationList");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Student_StudentID",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Documents",
                newName: "StudentDetialsID");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_StudentID",
                table: "Documents",
                newName: "IX_Documents_StudentDetialsID");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "ApplicationList",
                newName: "StudentDetialsID");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationList_StudentID",
                table: "ApplicationList",
                newName: "IX_ApplicationList_StudentDetialsID");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "AcademicRecord",
                newName: "StudentDetialsID");

            migrationBuilder.RenameIndex(
                name: "IX_AcademicRecord_StudentID",
                table: "AcademicRecord",
                newName: "IX_AcademicRecord_StudentDetialsID");

            migrationBuilder.CreateTable(
                name: "StudentDetials",
                columns: table => new
                {
                    StudentDetialsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AadharNumber = table.Column<string>(nullable: true),
                    ApplicantsMobileNumber = table.Column<string>(nullable: false),
                    BloodGroup = table.Column<string>(nullable: false),
                    Caste = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 25, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FamilyIncome = table.Column<decimal>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    GuardianMobileNumber = table.Column<string>(nullable: false),
                    GuradianOccupation = table.Column<string>(maxLength: 20, nullable: true),
                    Nationality = table.Column<string>(maxLength: 25, nullable: false),
                    PHStatus = table.Column<string>(maxLength: 3, nullable: false),
                    PlaceOfBirth = table.Column<string>(maxLength: 25, nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    RelWithGuardian = table.Column<string>(nullable: false),
                    ResidencePhone = table.Column<string>(nullable: true),
                    State = table.Column<string>(maxLength: 25, nullable: false),
                    StudentAddress = table.Column<string>(maxLength: 500, nullable: false),
                    StudentGuradianName = table.Column<string>(maxLength: 30, nullable: false),
                    StudentName = table.Column<string>(maxLength: 60, nullable: false),
                    StudentPhoto = table.Column<string>(nullable: false),
                    StudentSignature = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetials", x => x.StudentDetialsID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecord_StudentDetials_StudentDetialsID",
                table: "AcademicRecord",
                column: "StudentDetialsID",
                principalTable: "StudentDetials",
                principalColumn: "StudentDetialsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationList_StudentDetials_StudentDetialsID",
                table: "ApplicationList",
                column: "StudentDetialsID",
                principalTable: "StudentDetials",
                principalColumn: "StudentDetialsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_StudentDetials_StudentDetialsID",
                table: "Documents",
                column: "StudentDetialsID",
                principalTable: "StudentDetials",
                principalColumn: "StudentDetialsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
