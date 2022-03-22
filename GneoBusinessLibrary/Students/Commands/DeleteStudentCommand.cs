using GneoCommonDataLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Students.Commands
{

    public record DeleteStudentCommand(string idList) : IRequest<DeleteStudent> { }
    //public class DeleteStudentCommand : IRequest<DeleteStudent>    //same using record

    //{
    //    public DeleteStudent deleteStudent { get;}      

    //    public DeleteStudentCommand(DeleteStudent del)
    //    {
    //        deleteStudent = del;
    //    }
    //}

}
