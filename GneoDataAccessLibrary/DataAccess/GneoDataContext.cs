using GneoCommonDataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using GneoCommonDataLibrary.StoredProcedureModels;

namespace GneoDataAccessLibrary.DataAccess
{
    public class GneoDataContext:DbContext
    {
        public GneoDataContext(DbContextOptions options) : base(options) { }
        public  DbSet<Student> Students { get; set; }       
        public  DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<EnrollCourse> EnrollCourses { get; set; }

       // public DbSet<GetAllCourseIDs> GetAllCourseIDs { get; set; }



        

        

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


        public Task<List<Course>> GetCourseIds()
        {
            return Courses.FromSqlRaw<Course>("spGetAllAvailableCourses").ToListAsync();
        }

        public Task<List<Student>> GetAllStudentIds()
        {
            return Students.FromSqlRaw<Student>("spGetAllAvailableStudents").ToListAsync();
        }

        public Teacher InsertTeacher(Guid teacherid,string firstName, string lastName,bool isdeleted)
        {
            Teacher oTeacher = new() {TeacherID=teacherid ,FirstName = firstName, LastName = lastName,IsDeleted=false };
            Teachers.Add(oTeacher);
            SaveChangesAsync();

            return oTeacher;

        }

        // public CreateStudent InsertStudent(string FirstName, string LastName, DateTimeOffset Birthdate, string Email, string NIC, string RegistrationNumber)
        public Student InsertStudent(string firstName, string lastName, DateTimeOffset birthDate, string email, string NIC)
        {
           Student oStudent = new() { StudentID= Guid.NewGuid(), FirstName = firstName, LastName = lastName, Birthdate= birthDate, IsDeleted=false,Email= email, RegistrationID="STD011", NICNo=NIC};
         

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

            var delStd = Students.Where(a => a.StudentID.ToString() == ids.ToString()).FirstOrDefault();

          
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
