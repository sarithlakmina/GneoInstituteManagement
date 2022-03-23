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
using GneoBusinessLibrary.Students.Commands;
using GneoCommonDataLibrary.Models;

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

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CreateStudent value)
        {
            try
            {
                var result = await mediator.Send(new InsertStudentCommand(new CreateStudent()));
                return Ok(result);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }


        [HttpPut("{id}")]       
        public async Task<IActionResult> Update([FromBody]DeleteStudent command)
        {
            try
            {
                var result = await mediator.Send(new DeleteStudentCommand(command.IDList));
                return Ok();
            }
            catch 
            {
                return NoContent();
            }          
           
        }
    }
}
