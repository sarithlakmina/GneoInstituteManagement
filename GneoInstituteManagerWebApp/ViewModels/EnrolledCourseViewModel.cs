using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class EnrolledCourseViewModel
    {
        public List<Guid> CourseID { get; set; }

        public List<Guid> StudentID { get; set; }
    }
}
