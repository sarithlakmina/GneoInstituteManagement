using AutoMapper;
using GneoCommonDataLibrary.Models;
using GneoDataAccessLibrary.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Teachers.Queries
{
    public class GetAllTeachersQuery : IRequest<GetAllTeachersQueryResult>
    {
       
    }
    public class GetAllTeachersQueryResult
    {
        public List<Teacher> TeachersList { get; set; }
    }
   
}
