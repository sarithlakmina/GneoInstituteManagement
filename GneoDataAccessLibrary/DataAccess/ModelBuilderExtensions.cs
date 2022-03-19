using GneoCommonDataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoDataAccessLibrary.DataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Seeding Teacher Table
            modelBuilder.Entity<Teacher>().HasData(
               new Teacher
               {                   
                   TeacherID = new Guid("88373e03-ded6-4fcd-8d22-f98822cceffa"),
                   FirstName = "John",
                   LastName = "Doe",
                   IsDeleted = false
               },
               new Teacher
               {                   
                   TeacherID = new Guid("0e0ff77d-da0e-4bb0-b572-b4914d0c3d83"),
                   FirstName = "Jane",
                   LastName = "Doe",
                   IsDeleted = false
               }
               );
            #endregion

            #region Seeding Course Table
            modelBuilder.Entity<Course>().HasData(
               new Course
               {
                   CourseID = new Guid("c4ceff12-5590-4478-ad60-039acbc37c7c"),
                   CurrentStudentCount=5,
                   Description="This ",
                   MaximumStudentLimit=100,
                   Subject="Fundamentals of Programming", 
                   Title="Computer Science",
                   TeacherID=new Guid("88373e03-ded6-4fcd-8d22-f98822cceffa"),
                   IsDeleted = false,
                   TeacherFullName= ""
               },
               new Course
               {
                   CourseID = new Guid("cc96da43-9b5d-4e6c-889f-8afda52fe8a2"),
                   CurrentStudentCount = 5,
                   Description = "This ",
                   MaximumStudentLimit = 50,
                   Subject = "Pure Mathematics",
                   Title= "Trigonometry",
                   TeacherID=new Guid("0e0ff77d-da0e-4bb0-b572-b4914d0c3d83"),
                   IsDeleted = false,                  
               }
               );
            #endregion
        }
    }
}
