using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        [MaxLength(65)]

        public string TeacherFullName { get; set; }
        [Required]
        [MaxLength(30)]

        public string Subject { get; set; }
        public int CurrentStudentCount { get; set; }
        public int MaximumStudentLimit { get; set; }
        public bool CanEnrollMoreStudents => MaximumStudentLimit >= CurrentStudentCount;
        public bool IsDeleted { get; set; } = false;

        [Required]
        [ForeignKey("Teacher")]
        public Guid TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; } 
        public virtual ICollection<Student> Students { get; set; } 


    }
}
