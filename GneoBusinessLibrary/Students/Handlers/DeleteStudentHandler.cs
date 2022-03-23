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

        public DeleteStudentHandler(GneoDataContext _context)
        {
            Context = _context;
        }
        public Task<DeleteStudent> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return Task.FromResult(Context.DeleteStudent(request.idList));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
