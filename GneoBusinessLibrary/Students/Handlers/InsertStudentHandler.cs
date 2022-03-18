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
    public class InsertStudentHandler : IRequestHandler<InsertStudentCommand, Student>
    {
        public GneoDataContext Context;
        private readonly IMapper mapper;

        public InsertStudentHandler(GneoDataContext _context, IMapper _mapper)
        {
            Context = _context;
        }
        
        public Task<Student> Handle(InsertStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Context.InsertStudent(request.FirstName, request.LastName));
        }
    }
}
