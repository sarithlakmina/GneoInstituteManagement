using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class CreateStudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string Email { get; set; }
        public string NIC { get; set; }
    }
}
