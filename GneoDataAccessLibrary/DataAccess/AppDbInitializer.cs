using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GneoCommonDataLibrary.Common;
using GneoCommonDataLibrary.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GneoDataAccessLibrary.DataAccess
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            Guid g1 = new Guid("f7a87e41-baee-46ea-b930-95feb1efb0ea");
            Guid g2 = new Guid("e01a2f1d-6952-4bdd-87ae-0cea5711f1d1");

            try
            {
                using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<GneoDataContext>();

                    context.Database.EnsureCreated();

                    if (!context.Teachers.Any())
                    {
                        context.Teachers.AddRange(new List<Teacher>()
                        {
                            new Teacher()
                            {
                                TeacherID = g1,
                                FirstName = "John",
                                LastName = "Doe",
                                IsDeleted = false
                            },
                            new Teacher()
                            {
                                TeacherID = g2,
                                FirstName = "Jane",
                                LastName = "Doe",
                                IsDeleted = false
                            }
                        });
                                context.SaveChanges();
                    }

                    if (!context.Students.Any())
                    {

                    }

                    if (!context.Courses.Any())
                    {
                        context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            CourseID = new Guid("c4ceff12-5590-4478-ad60-039acbc37c7c"),
                            CurrentStudentCount = 5,
                            Description = "This ",
                            MaximumStudentLimit = 100,
                            Subject = "Fundamentals of Programming",
                            Title = "Computer Science",
                            TeacherID=g1,
                            IsDeleted = false,
                            TeacherFullName = ""
                        },
                        new Course()
                        {
                            CourseID = new Guid("cc96da43-9b5d-4e6c-889f-8afda52fe8a2"),
                            CurrentStudentCount = 5,
                            Description = "This ",
                            MaximumStudentLimit = 50,
                            Subject = "Pure Mathematics",
                            Title = "Trigonometry",
                            TeacherID=g2,
                            IsDeleted = false,
                            TeacherFullName = ""
                        }
                        });
                        context.SaveChanges();

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
