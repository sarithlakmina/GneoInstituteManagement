using GneoCommonDataLibrary.Configurations;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoWebAPI.Controllers.Definitions
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator mediator;
        protected readonly IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration;

        public BaseController(IMediator mediator, IOptionsSnapshot<GneoInstituteManagerConfigurations> configuration) : base()
        {
            this.mediator = mediator;
            this.configuration = configuration;
        }
    }
}
