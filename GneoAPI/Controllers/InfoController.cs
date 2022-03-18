using GneoAPI.Controllers.Definitions;
using GneoCommonDataLibrary.Configurations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : BaseController
    {

        public InfoController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration)
             : base(mediator, configuration)
        { }

        [HttpGet]
        [Route("")]
        public InfoConfig Get()
            => 
            configuration.Value.Info;
    }
}

