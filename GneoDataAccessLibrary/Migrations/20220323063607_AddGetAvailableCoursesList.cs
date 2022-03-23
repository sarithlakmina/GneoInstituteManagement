using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddGetAvailableCoursesList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetAllAvailableCourses
                                @ID int
                                as
                                begin
                                
                                    select CourseID from Courses
                                    where IsDeleted = 'false'
                                    
                                   
                                end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetAllAvailableCourses";

            migrationBuilder.Sql(procedure);
        }
    }
}
