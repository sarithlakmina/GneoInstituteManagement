using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class EnrollCourse
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }

        public Guid StudentID { get; set; }
    }
}
