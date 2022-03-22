using AutoMapper;
using GneoBusinessLibrary.Students.Queries;
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

namespace GneoAPI.Controllers
{
    [Route("api/[Controller]")]
    public class StudentController : BaseController
    {
        private readonly GneoDataContext _context;
        private readonly IMapper _mapper;
        private readonly GneoInstituteManagerConfigurations _snapshotOptions;



        public StudentController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration, IMapper mapper, GneoDataContext context)
           : base(mediator, configuration)
        {
            this._mapper = mapper;
            this._snapshotOptions = configuration.Value;
            this._context = context;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var result = await mediator.Send(new GetAllStudentsQuery());
                return Ok(result.StudentsList);
            }
            catch (Exception)
            {
                return NoContent();
            }

        }

        //[HttpPut("{id}")]
        //[Route("delete")]
        //public async Task<IActionResult> DeleteStudent(int id, bool isDeleted)
        //{
        //    try
        //    {
        //        var result = await mediator.Send(new GetAllStudentsQuery());
        //        return Ok();
        //    }
        //    catch (Exception)
        //    {

        //        return NoContent();
        //    }
        //}
    }
}
