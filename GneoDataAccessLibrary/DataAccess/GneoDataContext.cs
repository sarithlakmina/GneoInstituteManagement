using GneoCommonDataLibrary.Models;
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
        {
            return Teachers.ToListAsync();
        }

        public Task<List<EnrollCourse>> GetEnrollCourses()
        {
            return EnrollCourses.ToListAsync();
        }

        public Teacher InsertTeacher(string firstName, string lastName)
        {
            Teacher oTeacher = new() { FirstName = firstName, LastName = lastName };
            Teachers.Add(oTeacher);
            return oTeacher;

        }

        public Student InsertStudent(string firstName, string lastName)
        {
            Student oStudent = new() { FirstName = firstName, LastName = lastName };
            Students.Add(oStudent);
            return oStudent;

        }

        public EnrollCourse InsertCourse(Guid id, Guid courseId, Guid studentId)
        {
            EnrollCourse oCourse = new() {ID=id, CourseID = courseId, StudentID = studentId };
            EnrollCourses.Add(oCourse);
            return oCourse;

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
           
        //}


    }
}
