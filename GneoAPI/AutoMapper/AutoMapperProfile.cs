using AutoMapper;
using GneoCommonDataLibrary.ViewModels;
using GneoCommonDataLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoAPI.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"))
                ;
            CreateMap<Student, StudentViewModel>()
                .ForMember(c => c.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"))
                ;
        }
    }
}
