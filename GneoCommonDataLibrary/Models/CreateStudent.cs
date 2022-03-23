using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class CreateStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string Email { get; set; }
        public string NIC { get; set; }
        public string RegistrationNumber { get; set; } 
    }
}
