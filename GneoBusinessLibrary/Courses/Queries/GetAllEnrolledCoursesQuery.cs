using GneoCommonDataLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Courses.Queries
{
    public class GetAllEnrolledCoursesQuery:IRequest<GetAllEnrolledCoursesQueryResult>
    {
    }
    public class GetAllEnrolledCoursesQueryResult
    {
        public List<EnrollCourse> EnrolledCoursesList { get; set; }
    }
}
