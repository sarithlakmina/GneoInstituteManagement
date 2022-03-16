
using GneoCommonDataLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Teachers.Commands
{

    public record InsertTeacherCommand(string FirstName, string LastName) : IRequest<Teacher> { }

    //public class InsertTeacherCommand :IRequest<Teacher>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public InsertTeacherCommand(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;

    //    }

    //}
}
