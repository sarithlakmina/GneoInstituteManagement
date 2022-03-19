﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GneoDataAccessLibrary.Migrations
{
    public partial class SeedTeachersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { new Guid("1b57b4d0-1c8f-483c-92b7-52b339e4869a"), "John", false, "Doe" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { new Guid("0891bc32-0049-424e-9799-dad9053f5ad9"), "Jane", false, "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: new Guid("0891bc32-0049-424e-9799-dad9053f5ad9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: new Guid("1b57b4d0-1c8f-483c-92b7-52b339e4869a"));
        }
    }
}
