using AutoMapper;
using GneoBusinessLibrary.Courses.Queries;
using GneoCommonDataLibrary.Configurations;
using GneoDataAccessLibrary.DataAccess;
using GneoAPI.Controllers.Definitions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GneoCommonDataLibrary.Models;
using GneoBusinessLibrary.Courses.Commands;

namespace GneoAPI.Controllers
{
    [Route("api/[Controller]")]
    public class CourseController : BaseController
    {
        private readonly GneoDataContext _context;
        private readonly IMapper _mapper;
        private readonly GneoInstituteManagerConfigurations _snapshotOptions;
        

        public CourseController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration, IMapper mapper, GneoDataContext context)
            : base(mediator, configuration)
        {
            this._mapper = mapper;
            this._snapshotOptions = configuration.Value;
            this._context = context;
        }

        

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> All()
        {

            try
            {
                var result = await mediator.Send(new GetAllCoursesQuery());
              
                return Ok(result.CoursesList);
            }
            catch (Exception)
            {
                return NoContent();
            }

        }

        [HttpPost]
        [Route("enroll")]
        public async Task<IActionResult> Enroll([FromBody]EnrollCourse value)
        {
            try
            {
                var result = await mediator.Send(new InsertCourseCommand(value.CourseID, value.StudentID));
                return Ok(result.CourseID);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("enrolled")]
        public async Task<IActionResult> enrolled()
        {

            try
            {
                var result = await mediator.Send(new GetAllEnrolledCoursesQuery());

                return Ok(result.EnrolledCoursesList);
            }
            catch (Exception)
            {
                return NoContent();
            }

        }

    }
}
