using AutoMapper;
using GneoBusinessLibrary.Teachers.Commands;
using GneoCommonDataLibrary.Models;
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
    public class InsertTeacherHandler : IRequestHandler<InsertTeacherCommand, Teacher> 
    {
        public GneoDataContext Context;
        private readonly IMapper mapper;

        public InsertTeacherHandler(GneoDataContext _context, IMapper _mapper)
        {
            Context = _context;
        }
        public Task<Teacher> Handle(InsertTeacherCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Context.InsertTeacher(request.TeacherId,request.FirstName, request.LastName,false));
        }
    }
}
