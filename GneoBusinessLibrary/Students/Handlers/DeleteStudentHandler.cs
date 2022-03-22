using AutoMapper;
using GneoBusinessLibrary.Students.Commands;
using GneoCommonDataLibrary.Models;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Students.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, DeleteStudent>
    {
        public GneoDataContext Context;
        private readonly IMapper mapper;

        public DeleteStudentHandler(GneoDataContext _context, IMapper _mapper)
        {
            Context = _context;
        }       
        

        

        public Task<DeleteStudent> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Context.DeleteStudent(request.idList));
        }
    }
}
