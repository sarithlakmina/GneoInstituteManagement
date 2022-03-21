using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrollCourses",
                table: "EnrollCourses");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "EnrollCourses");

            migrationBuilder.AddColumn<Guid>(
                name: "CoursesCourseID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrollCourses",
                table: "EnrollCourses",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoursesCourseID",
                table: "Students",
                column: "CoursesCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesCourseID",
                table: "Students",
                column: "CoursesCourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesCourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CoursesCourseID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrollCourses",
                table: "EnrollCourses");

            migrationBuilder.DropColumn(
                name: "CoursesCourseID",
                table: "Students");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "EnrollCourses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrollCourses",
                table: "EnrollCourses",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CourseofStudentCourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsStudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CourseofStudentCourseID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CourseofStudentCourseID",
                        column: x => x.CourseofStudentCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudentID",
                table: "CourseStudent",
                column: "StudentsStudentID");
        }
    }
}
