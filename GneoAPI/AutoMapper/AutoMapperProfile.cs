using AutoMapper;
using GneoCommonDataLibrary.Models;
using GneoCommonDataLibrary.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoAPI.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Course, CourseViewModel>()
                .ForMember(c => c.TeacherFullName, o => o.MapFrom(c => $"{c.Teacher.FirstName} {c.Teacher.LastName}"))
                .ForMember(c => c.CurrentStudentCount, o => o.MapFrom(c => c.Students.Count))
                .ForMember(c => c.CanEnrollMoreStudents, o => o.Ignore());
            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"))
                ;
            CreateMap<Student, StudentViewModel>()
                .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"))
                ;
            CreateMap<Teacher, Course>()
                .ForMember(t => t.TeacherID, o => o.MapFrom(c => c.TeacherID))
                ;
        }
    }
}
