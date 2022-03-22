using GneoCommonDataLibrary.Models;
using GneoCommonDataLibrary.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoDataAccessLibrary.DataAccess
{
    public class GneoDataContext:DbContext
    {
        public GneoDataContext(DbContextOptions options) : base(options) { }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Course> Courses { get; set; }
        public  DbSet<Teacher> Teachers { get; set; }

        public DbSet<EnrollCourse> EnrollCourses { get; set; }

        

        

        public Task<List<Course>> GetAllCourses()
           => Courses.Where(c => !c.IsDeleted).OrderBy(c => c.Title).AsNoTracking().ToListAsync();

        public Task<List<Teacher>> GetAllTeachers()
           => Teachers.Where(c => !c.IsDeleted).OrderBy(c => c.TeacherID).AsNoTracking().ToListAsync();

        public Task<List<Student>> GetAllStudents()
          => Students.Where(c => !c.IsDeleted).OrderBy(c => c.StudentID).AsNoTracking().ToListAsync();

        public Task<List<Teacher>> GetRegisteredTeachers()        
          => Teachers.ToListAsync();
        
        public Task<List<EnrollCourse>> GetEnrollCourses()
            => EnrollCourses.ToListAsync();


        public Task<List<Guid>> GetCourseIds()
         => Courses.Select(x => x.CourseID).ToListAsync();



        public Teacher InsertTeacher(Guid teacherid,string firstName, string lastName,bool isdeleted)
        {
            Teacher oTeacher = new() {TeacherID=teacherid ,FirstName = firstName, LastName = lastName,IsDeleted=false };
            Teachers.Add(oTeacher);
            SaveChangesAsync();

            return oTeacher;

        }

        public Student InsertStudent(string firstName, string lastName)
        {
            Student oStudent = new() { FirstName = firstName, LastName = lastName };
            Students.Add(oStudent);
            SaveChangesAsync();
            return oStudent;

        }

        public EnrollCourse InsertCourse(Guid courseId, Guid studentId)
        {
            EnrollCourse oCourse = new() {CourseID = courseId, StudentID = studentId };
            EnrollCourses.Add(oCourse);
            SaveChangesAsync();
            return oCourse;

        }

        public DeleteStudent DeleteStudent(string ids)
        {
            DeleteStudent oDelStudent = new() { IDList = ids };

            var delStd = Students.Where(a => a.StudentID.ToString() == "9951573b-d3e5-42fb-ae15-0170d4bf2eb9").FirstOrDefault();

          
            if(delStd == null)
            {
                return default;
            }
            else
            {
                delStd.IsDeleted = true;
                SaveChangesAsync();
                return oDelStudent;
            }

        }


    }
}
