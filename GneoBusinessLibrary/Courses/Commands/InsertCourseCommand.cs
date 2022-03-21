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

namespace GneoBusinessLibrary.Courses.Commands
{
    public record InsertCourseCommand(Guid CourseID, Guid StudentID) : IRequest<EnrollCourse> { }
}

