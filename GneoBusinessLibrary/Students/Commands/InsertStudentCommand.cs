using GneoCommonDataLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Students.Commands
{
    public record InsertStudentCommand(CreateStudent createstudent) : IRequest<CreateStudent> { }
}
