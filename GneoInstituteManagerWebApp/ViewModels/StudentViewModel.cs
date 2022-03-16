using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class StudentViewModel
    {
        [Display(Name="Full Name")]
        public string FullName { get; set; }
        
        [Display(Name = "Course ID")]
        public string CourseID { get; set; }
    }
}
