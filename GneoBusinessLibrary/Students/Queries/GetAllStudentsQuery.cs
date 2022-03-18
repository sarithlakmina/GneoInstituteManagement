using AutoMapper;
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

namespace GneoBusinessLibrary.Students.Queries
{
    public class GetAllStudentsQuery : IRequest<GetAllStudentsQueryResult>
    {
    }

    public class GetAllStudentsQueryResult
    {
        public List<StudentViewModel> StudentsList { get; set; }
    }


}
