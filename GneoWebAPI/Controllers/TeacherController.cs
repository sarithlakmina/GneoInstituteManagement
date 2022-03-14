using AutoMapper;
using GneoBusinessLibrary.Queries.Teachers;
using GneoCommonDataLibrary.Configurations;
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


        public TeacherController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration,IMapper mapper)
            : base(mediator, configuration)
        {
            this._mapper = mapper;
            _snapshotOptions = configuration.Value;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllTeachers()
        {
            var result = await mediator.Send(new GetAllTeachersQuery());
            var res=result.TeachersList;

            var teacherViewModel = _mapper.Map<TeacherViewModel>(res);

            return Ok(teacherViewModel);
        }

        public async Task<IActionResult> AddEditTeacher(int id = 0)
        {
            if (id == 0)
            {
                return Ok();
            }
            else
            {
                var AddEditTeacherModel = await _context.Teachers.FindAsync(id);
                if (AddEditTeacherModel == null)
                {
                    return NotFound();
                }

                return Ok(AddEditTeacherModel);
            }

        }
    }
}
