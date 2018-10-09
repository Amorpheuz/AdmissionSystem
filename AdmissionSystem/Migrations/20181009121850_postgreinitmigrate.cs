using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AdmissionSystem.Migrations
{
    public partial class postgreinitmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AcademicRecord_Student_StudentID",
            //    table: "AcademicRecord");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ApplicationList_AcademicYear_AcademicYearID",
            //    table: "ApplicationList");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ApplicationList_Student_StudentID",
            //    table: "ApplicationList");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Documents_Student_StudentID",
            //    table: "Documents");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Fees_AcademicYear_AcademicYearID",
            //    table: "Fees");

            //migrationBuilder.AlterColumn<int>(
            //    name: "StudentID",
            //    table: "Student",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            //migrationBuilder.AlterColumn<int>(
            //    name: "AcademicYearID",
            //    table: "Fees",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "FeesID",
            //    table: "Fees",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            //migrationBuilder.AlterColumn<int>(
            //    name: "StudentID",
            //    table: "Documents",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "StudentID",
            //    table: "ApplicationList",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "AcademicYearID",
            //    table: "ApplicationList",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "ApplicationListID",
            //    table: "ApplicationList",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            //migrationBuilder.AlterColumn<int>(
            //    name: "AcademicYearID",
            //    table: "AcademicYear",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            //migrationBuilder.AlterColumn<int>(
            //    name: "StudentID",
            //    table: "AcademicRecord",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "AcademicRecordID",
            //    table: "AcademicRecord",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AcademicRecord_Student_StudentID",
            //    table: "AcademicRecord",
            //    column: "StudentID",
            //    principalTable: "Student",
            //    principalColumn: "StudentID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApplicationList_AcademicYear_AcademicYearID",
            //    table: "ApplicationList",
            //    column: "AcademicYearID",
            //    principalTable: "AcademicYear",
            //    principalColumn: "AcademicYearID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApplicationList_Student_StudentID",
            //    table: "ApplicationList",
            //    column: "StudentID",
            //    principalTable: "Student",
            //    principalColumn: "StudentID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Documents_Student_StudentID",
            //    table: "Documents",
            //    column: "StudentID",
            //    principalTable: "Student",
            //    principalColumn: "StudentID",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
                //name: "FK_Fees_AcademicYear_AcademicYearID",
                //table: "Fees",
                //column: "AcademicYearID",
                //principalTable: "AcademicYear",
                //principalColumn: "AcademicYearID",
                //onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecord_Student_StudentID",
                table: "AcademicRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationList_AcademicYear_AcademicYearID",
                table: "ApplicationList");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationList_Student_StudentID",
                table: "ApplicationList");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Student_StudentID",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_AcademicYear_AcademicYearID",
                table: "Fees");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AcademicYearID",
                table: "Fees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FeesID",
                table: "Fees",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "ApplicationList",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AcademicYearID",
                table: "ApplicationList",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationListID",
                table: "ApplicationList",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AcademicYearID",
                table: "AcademicYear",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "AcademicRecord",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AcademicRecordID",
                table: "AcademicRecord",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecord_Student_StudentID",
                table: "AcademicRecord",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationList_AcademicYear_AcademicYearID",
                table: "ApplicationList",
                column: "AcademicYearID",
                principalTable: "AcademicYear",
                principalColumn: "AcademicYearID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_AcademicYear_AcademicYearID",
                table: "Fees",
                column: "AcademicYearID",
                principalTable: "AcademicYear",
                principalColumn: "AcademicYearID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
