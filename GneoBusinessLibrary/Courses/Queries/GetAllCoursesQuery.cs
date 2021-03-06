using AutoMapper;
using GneoCommonDataLibrary.Models;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Courses.Queries
{
    public class GetAllCoursesQuery : IRequest<GetAllCoursesQueryResult>
    {
    }

    public class GetAllCoursesQueryResult
    {
        public List<Course> CoursesList { get; set; }
    }

}
