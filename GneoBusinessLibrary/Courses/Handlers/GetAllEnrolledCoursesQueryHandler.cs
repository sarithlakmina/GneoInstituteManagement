using AutoMapper;
using GneoBusinessLibrary.Courses.Queries;
using GneoCommonDataLibrary.Models;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Courses.Handlers
{
    public class GetAllEnrolledCoursesQueryHandler : IRequestHandler<GetAllEnrolledCoursesQuery, GetAllEnrolledCoursesQueryResult>
    {
        private readonly GneoDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllEnrolledCoursesQueryHandler(GneoDataContext _context, IMapper _mapper)
        {
            this.dataContext = _context;
            this.mapper = _mapper;
        }
        

        public async Task<GetAllEnrolledCoursesQueryResult> Handle(GetAllEnrolledCoursesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var EnroleldCourses = await dataContext.GetEnrollCourses();

                return new GetAllEnrolledCoursesQueryResult
                {
                    EnrolledCoursesList = mapper.Map<List<EnrollCourse>>(EnroleldCourses)
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
