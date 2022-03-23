﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class AddGetAvailableCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetAllAvailableCourses
                                @ID int
                                as
                                begin
                                
                                    select CourseId from Courses
                                    
                                   
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
