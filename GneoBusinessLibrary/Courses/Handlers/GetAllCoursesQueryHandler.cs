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
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, GetAllCoursesQueryResult>
    {
        private readonly GneoDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllCoursesQueryHandler(GneoDataContext _context, IMapper _mapper)
        {
            this.dataContext = _context;
            this.mapper = _mapper;
        }
        public async Task<GetAllCoursesQueryResult> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var Courses = await dataContext.GetAllCourses();

            return new GetAllCoursesQueryResult
            {
                CoursesList = mapper.Map<List<Course>>(Courses)
            };
        }
    }
}
