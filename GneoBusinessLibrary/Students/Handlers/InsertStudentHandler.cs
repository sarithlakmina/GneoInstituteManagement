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
    public class InsertStudentHandler : IRequestHandler<InsertStudentCommand, CreateStudent>
    {
        public GneoDataContext Context;

        public InsertStudentHandler(GneoDataContext _context)
        {
            Context = _context;
        }
        
        Task<CreateStudent> IRequestHandler<InsertStudentCommand, CreateStudent>.Handle(InsertStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Context.InsertStudent(request.createstudent));
        }
    }
}
