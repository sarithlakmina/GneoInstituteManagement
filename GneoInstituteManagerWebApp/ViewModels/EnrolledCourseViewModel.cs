using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class EnrolledCourseViewModel
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }

        public Guid StudentID { get; set; }
    }
}
