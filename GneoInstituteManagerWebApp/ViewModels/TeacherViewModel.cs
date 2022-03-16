using GneoCommonDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class TeacherViewModel
    {
        [Display(Name = "Teacher ID")]
        public Guid TeacherID { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        
        
    }
}
