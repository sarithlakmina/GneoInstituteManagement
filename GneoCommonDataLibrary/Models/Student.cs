using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class Student
    {
        public Guid StudentID { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        [Column(TypeName="varchar(200)")]
        public string Email { get; set; }
        public string DateofBirth { get; set; }
        public List<Course> CourseofStudent { get; set; } = new List<Course>();
        public bool IsDeleted { get; set; }
    }
}
