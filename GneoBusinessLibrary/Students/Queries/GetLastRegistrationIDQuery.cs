using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoBusinessLibrary.Students.Queries
{
    public class GetLastRegistrationIDQuery : IRequest<GetLastRegistrationIDQueryResult>
    {
    }
    public class GetLastRegistrationIDQueryResult
    {
        public string RegID { get; set; }
    }
}
