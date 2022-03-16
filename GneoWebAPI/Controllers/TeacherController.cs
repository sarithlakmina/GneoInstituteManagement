using AutoMapper;
using GneoBusinessLibrary.Teachers.Commands;
using GneoBusinessLibrary.Teachers.Queries;
using GneoCommonDataLibrary.Configurations;
using GneoCommonDataLibrary.Models;
using GneoCommonDataLibrary.ViewModels;
using GneoDataAccessLibrary.DataAccess;
using GneoWebAPI.Controllers.Definitions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoWebAPI.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly GneoDataContext _context;
        private readonly IMapper _mapper;
        private readonly GneoInstituteManagerConfigurations _snapshotOptions;
        public TeacherController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration, IMapper mapper, GneoDataContext context)
            : base(mediator, configuration)
        {
            this._mapper = mapper;
            this._snapshotOptions = configuration.Value;
            this._context = context;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllTeachers()
        {
            try
            {
                var result = await mediator.Send(new GetAllTeachersQuery());
                return Ok(result.TeachersList);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
        [HttpPost]
        [Route("enroll")]
        public async Task<IActionResult> InsertTeacher(Teacher value)
        {
            try
            {
                var result = await mediator.Send(new InsertTeacherCommand(value.FirstName,value.LastName));               
                return Ok();
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}
