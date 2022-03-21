using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GneoCommonDataLibrary.Common;
using GneoCommonDataLibrary.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using static GneoCommonDataLibrary.Common.AdditionalSeedingData;

namespace GneoDataAccessLibrary.DataAccess
{
    public class AppDbInitializer
    {
        private readonly GneoDataContext _context;
        private static Guid g1 = new Guid("f7a87e41-baee-46ea-b930-95feb1efb0ea");
        private static Guid g2 = new Guid("e01a2f1d-6952-4bdd-87ae-0cea5711f1d1");

        private static Guid c1 = new Guid("c4ceff12-5590-4478-ad60-039acbc37c7c");
        private static Guid c2 = new Guid("cc96da43-9b5d-4e6c-889f-8afda52fe8a2");

        private static Course objCourse1 = new Course();
        private static Course objCourse2 = new Course();

        private static Teacher objTeacher1 = new Teacher();
        private static Teacher objTeacher2 = new Teacher();

        private static Student objStudent1 = new Student();
        private static Student objStudent2 = new Student();
        private static Student objStudent3 = new Student();
        private static Student objStudent4 = new Student();
        private static Student objStudent5 = new Student();
        private static Student objStudent6 = new Student();
        private static Student objStudent7 = new Student();
        private static Student objStudent8 = new Student();
        private static Student objStudent9 = new Student();
        private static Student objStudent10 = new Student();










        public AppDbInitializer(GneoDataContext context)
        {
            this._context = context;
        }
        public static void Seed(IApplicationBuilder appBuilder)
        {

            try
            {
                GetTeacherObjects();
                GetStudentsObjects();
                GetCourseObjects();





                using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<GneoDataContext>();

                    context.Database.EnsureCreated();

                    if (!context.Teachers.Any())
                    {
                        context.Teachers.AddRange(new List<Teacher>()
                        {
                           objTeacher1,objTeacher2
                        });
                        context.SaveChanges();
                    }

                    if (!context.Students.Any())
                    {
                        context.Students.AddRange(new List<Student>()
                    {
                        objStudent1,
                        objStudent2,
                        objStudent3,
                        objStudent4,
                        objStudent5,
                        objStudent6,
                        objStudent7,
                        objStudent8,
                        objStudent9,
                        objStudent10
                     });
                        context.SaveChanges();
                    }

                    if (!context.Courses.Any())
                    {
                        context.Courses.AddRange(new List<Course>()
                    {
                        objCourse1,
                        objCourse2
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

        public static void GetCourseObjects()
        {
            objCourse1.CourseID = c1;
            objCourse1.CurrentStudentCount = 7;
            objCourse1.Description = "Course description of course 1";
            objCourse1.MaximumStudentLimit = 100;
            objCourse1.Subject = SubjectDetails.Subject1.ToString();
            objCourse1.Title = Titles.title1.ToString();
            objCourse1.TeacherID = g1;
            objCourse1.IsDeleted = false;
            objCourse1.TeacherFullName = objTeacher1.GetFullName;
            objCourse1.Teacher = objTeacher1;

            ICollection<Student> collection1 = new List<Student>();
            collection1.Add(objStudent1);

            objCourse1.Students = collection1;

            objCourse2.CourseID = c2;
            objCourse2.CurrentStudentCount = 3;
            objCourse2.Description = "Course description of course 2";
            objCourse2.MaximumStudentLimit = 50;
            objCourse2.Subject = SubjectDetails.Subject2.ToString();
            objCourse2.Title = Titles.title2.ToString();
            objCourse2.TeacherID = g2;
            objCourse2.IsDeleted = false;
            objCourse2.TeacherFullName = objTeacher2.GetFullName;
            objCourse2.Students = collection1;
            objCourse2.Teacher = objTeacher2;
        }

        public static void GetTeacherObjects()
        {
            objTeacher1.TeacherID = g1;
            objTeacher1.FirstName = "John";
            objTeacher1.LastName = "Doe";
            objTeacher1.IsDeleted = false;

            objTeacher2.TeacherID = g2;
            objTeacher2.FirstName = "Jane";
            objTeacher2.LastName = "Doe";
            objTeacher2.IsDeleted = false;
        }

        public static void GetStudentsObjects()
        {
            objStudent1.Birthdate = new DateTimeOffset(2008, 5, 1, 8, 6, 32,
                                 new TimeSpan(1, 0, 0));
            objStudent1.StudentID = Guid.NewGuid();
            objStudent1.RegistrationID = "STD001";
            objStudent1.FirstName = "James";
            objStudent1.LastName = "Butt";
            objStudent1.Email = "jbutt@gmail.com";
            objStudent1.NICNo = "199112304556";
            objStudent1.IsDeleted = false;
            objStudent1.Courses = objCourse1;

            objStudent2.Birthdate = new DateTimeOffset(2001, 6, 2, 8, 6, 32,
                    new TimeSpan(1, 0, 0));
            objStudent2.StudentID = Guid.NewGuid();
            objStudent2.RegistrationID = "STD002";
            objStudent2.FirstName = "Josephine";
            objStudent2.LastName = "Darakjy";
            objStudent2.Email = "josephine_darakjy@darakjy.org";
            objStudent2.NICNo = "200162863210";
            objStudent2.IsDeleted = false;
            objStudent2.Courses = objCourse2;

            objStudent3.Birthdate = new DateTimeOffset(2000, 7, 11, 9, 6, 32,
                  new TimeSpan(1, 0, 0));
            objStudent3.StudentID = Guid.NewGuid();
            objStudent3.RegistrationID = "STD003";
            objStudent3.FirstName = "James";
            objStudent3.LastName = "Butt";
            objStudent3.Email = "jbutt@gmail.com";
            objStudent3.NICNo = "199912304556";
            objStudent3.IsDeleted = false;
            objStudent3.Courses = objCourse1;

            objStudent4.Birthdate = new DateTimeOffset(2001, 6, 2, 8, 6, 32,
                    new TimeSpan(1, 0, 0));
            objStudent4.StudentID = Guid.NewGuid();
            objStudent4.RegistrationID = "STD002";
            objStudent4.FirstName = "Josephine";
            objStudent4.LastName = "Darakjy";
            objStudent4.Email = "josephine_darakjy@darakjy.org";
            objStudent4.NICNo = "200162863210";
            objStudent4.IsDeleted = false;
            objStudent4.Courses = objCourse2;




            objStudent5.Birthdate = new DateTimeOffset(2008, 5, 1, 8, 6, 32,
                                new TimeSpan(1, 0, 0));
            objStudent5.StudentID = Guid.NewGuid();
            objStudent5.RegistrationID = "STD001";
            objStudent5.FirstName = "James";
            objStudent5.LastName = "Butt";
            objStudent5.Email = "jbutt@gmail.com";
            objStudent5.NICNo = "199112304556";
            objStudent1.IsDeleted = false;
            objStudent5.Courses = objCourse1;

            objStudent6.Birthdate = new DateTimeOffset(2001, 6, 2, 8, 6, 32,
                    new TimeSpan(1, 0, 0));
            objStudent6.StudentID = Guid.NewGuid();
            objStudent6.RegistrationID = "STD002";
            objStudent6.FirstName = "Josephine";
            objStudent6.LastName = "Darakjy";
            objStudent6.Email = "josephine_darakjy@darakjy.org";
            objStudent6.NICNo = "200162863210";
            objStudent6.IsDeleted = false;
            objStudent6.Courses = objCourse2;

            objStudent7.Birthdate = new DateTimeOffset(2000, 7, 11, 9, 6, 32,
                  new TimeSpan(1, 0, 0));
            objStudent7.StudentID = Guid.NewGuid();
            objStudent7.RegistrationID = "STD003";
            objStudent7.FirstName = "James";
            objStudent7.LastName = "Butt";
            objStudent7.Email = "jbutt@gmail.com";
            objStudent7.NICNo = "199912304556";
            objStudent7.IsDeleted = false;
            objStudent7.Courses = objCourse1;

            objStudent8.Birthdate = new DateTimeOffset(2001, 6, 2, 8, 6, 32,
                    new TimeSpan(1, 0, 0));
            objStudent8.StudentID = Guid.NewGuid();
            objStudent8.RegistrationID = "STD002";
            objStudent8.FirstName = "Josephine";
            objStudent8.LastName = "Darakjy";
            objStudent8.Email = "josephine_darakjy@darakjy.org";
            objStudent8.NICNo = "200162863210";
            objStudent8.IsDeleted = false;
            objStudent8.Courses = objCourse2;


            objStudent9.Birthdate = new DateTimeOffset(2000, 7, 11, 9, 6, 32,
                  new TimeSpan(1, 0, 0));
            objStudent9.StudentID = Guid.NewGuid();
            objStudent9.RegistrationID = "STD003";
            objStudent9.FirstName = "James";
            objStudent9.LastName = "Butt";
            objStudent9.Email = "jbutt@gmail.com";
            objStudent9.NICNo = "199912304556";
            objStudent9.IsDeleted = false;
            objStudent9.Courses = objCourse1;

            objStudent10.Birthdate = new DateTimeOffset(2001, 6, 2, 8, 6, 32,
                    new TimeSpan(1, 0, 0));
            objStudent10.StudentID = Guid.NewGuid();
            objStudent10.RegistrationID = "STD002";
            objStudent10.FirstName = "Josephine";
            objStudent10.LastName = "Darakjy";
            objStudent10.Email = "josephine_darakjy@darakjy.org";
            objStudent10.NICNo = "200162863210";
            objStudent10.IsDeleted = false;
            objStudent10.Courses = objCourse2;


        }

    }
}

