using GneoCommonDataLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Students.Commands
{
    public record InsertStudentCommand(string firstName, string lastName, DateTimeOffset birthDate,string email, string NIC) : IRequest<Student> { }

    
}
