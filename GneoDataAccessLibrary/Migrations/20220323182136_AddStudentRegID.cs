using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddStudentRegID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetStudentRegisterID
                                
                                 as
                                 begin
                                SELECT Max(dbo.udf_GetNumeric(RegistrationID)) 
                                from dbo.Students
                                    
                                   
                                end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetStudentRegisterID";

            migrationBuilder.Sql(procedure);
        }
    }
}
