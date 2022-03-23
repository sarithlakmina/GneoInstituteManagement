using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddAutoIncrementRegID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetStudentRegID
                                
                                 as
                                 begin
                                SELECT Max(dbo.udf_GetNumeric(RegistrationID)) 
                                from dbo.Students
                                    
                                   
                                end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetStudentRegID";

            migrationBuilder.Sql(procedure);
        }
    }
}
