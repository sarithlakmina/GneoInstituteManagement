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
        public string RegistrationID { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName="varchar(200)")]
        public string Email { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public bool IsDeleted { get; set; }

        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar(12)")]
        public string NICNo { get; set; }
        public string GetFullName => $"{FirstName} {LastName}";

        public virtual Course Courses { get; set; }
    }
}
