using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.ViewModels
{
    public class CourseViewModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeacherFullName { get; set; }
        public string Subject { get; set; }
        public int CurrentStudentCount { get; set; }
        public int MaximumStudentLimit { get; set; }
        public bool CanEnrollMoreStudents => MaximumStudentLimit <= CurrentStudentCount;
    }
}
