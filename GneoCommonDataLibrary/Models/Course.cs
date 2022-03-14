using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class Course
    {
        public Guid CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeacherFullName { get; set; }
        public string Subject { get; set; }
        public int CurrentStudentCount { get; set; }
        public int MaximumStudentLimit { get; set; }
        public bool CanEnrollMoreStudents => MaximumStudentLimit <= CurrentStudentCount;
        public bool IsDeleted { get; set; } = false;

        public virtual Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

    }
}
