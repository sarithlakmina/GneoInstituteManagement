using GneoBusinessLibrary.Teachers.Queries;
using GneoCommonDataLibrary.ViewModels;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Teachers.Handlers
{
    public class GetTeacherByIDHandler : IRequestHandler<GetTeacherByIDQuery, TeacherViewModel>
    {
        private readonly IMediator _mediator;

        public GneoDataContext Context;
        public GetTeacherByIDHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TeacherViewModel> Handle(GetTeacherByIDQuery request, CancellationToken cancellationToken)
        {
            var results= await _mediator.Send(new GetAllTeachersQuery());
           /* var output = results.(x => x.ID == request.id);
            return output;*/
            return null;
        }
    }
}
