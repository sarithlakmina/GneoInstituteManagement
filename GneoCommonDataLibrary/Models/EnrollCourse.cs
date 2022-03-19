using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class EnrollCourse
    {
        public Guid ID { get; set; }

        [Required]
        public Guid CourseID { get; set; }
        [Required]
        public Guid StudentID { get; set; }
    }
}
