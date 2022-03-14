﻿using AutoMapper;
using GneoCommonDataLibrary.Models;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Queries.Teachers
{
    public class GetAllTeachersQuery : IRequest<GetAllTeachersQueryResult>
    {
       
    }
    public class GetAllTeachersQueryResult
    {
        public List<Teacher> TeachersList { get; set; }
    }
    public class GetAllTeachersQueryHandler : IRequestHandler<GetAllTeachersQuery, GetAllTeachersQueryResult>
    {
        private readonly GneoDataContext dataContext;
        private readonly IMapper mapper;

        public GetAllTeachersQueryHandler(GneoDataContext _context, IMapper _mapper)
        {
            this.dataContext=_context;
            this.mapper = _mapper; 
        }
        public async Task<GetAllTeachersQueryResult> Handle(GetAllTeachersQuery request, CancellationToken cancellationToken)
        {
            var teachers = await dataContext.GetAllTeachers();

            return new GetAllTeachersQueryResult
            {
                TeachersList = mapper.Map<List<Teacher>>(teachers)
            };
        }
    }
}
