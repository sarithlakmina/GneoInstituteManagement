using GneoCommonDataLibrary.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Teachers.Queries
{
    public record GetTeacherByIDQuery(int id) : IRequest<TeacherViewModel>;
}
