using AutoMapper;
using GneoBusinessLibrary.Students.Queries;
using GneoBusinessLibrary.Teachers.Queries;
using GneoCommonDataLibrary.Models;
using GneoCommonDataLibrary.ViewModels;
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
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, GetAllStudentsQueryResult>
    {
        private readonly GneoDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllStudentsQueryHandler(GneoDataContext _context, IMapper _mapper)
        {
            this.dataContext = _context;
            this.mapper = _mapper;
        }
        

        public async Task<GetAllStudentsQueryResult> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var students = await dataContext.GetAllStudents();

                return new GetAllStudentsQueryResult
                {
                    StudentsList = mapper.Map<List<StudentViewModel>>(students)
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
