using AutoMapper;
using GneoBusinessLibrary.Courses.Commands;
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
    public class InsertCourseHandler : IRequestHandler<InsertCourseCommand, EnrollCourse>
    {
        public GneoDataContext Context;

        public InsertCourseHandler(GneoDataContext _context, IMapper _mapper)
        {
            Context = _context;
        }

        public Task<EnrollCourse> Handle(InsertCourseCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return Task.FromResult(Context.InsertCourse(request.CourseID, request.StudentID));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
