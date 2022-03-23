using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.ViewModels
{
    public class StudentViewModel
    {
        [Display(Name="Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Student ID")]
        public Guid StudentID { get; set; }

        [Display(Name = "Registration ID")]        
        public string RegistrationID { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        public DateTimeOffset Birthdate { get; set; }
        
        [Display(Name = "NIC")]
        public string NICNo { get; set; }

        
    }
}
