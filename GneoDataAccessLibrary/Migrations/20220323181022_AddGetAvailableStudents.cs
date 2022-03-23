using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddGetAvailableStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetAllAvailableStudents
                                @ID int
                                as
                                begin
                                
                                    select StudentID from Students
                                    where IsDeleted = 'false'
                                    
                                   
                                end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetAllAvailableStudents";

            migrationBuilder.Sql(procedure);
        }
    }
}
