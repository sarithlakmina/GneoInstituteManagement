using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class CreateStudent
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar(12)")]
        public string NIC { get; set; }
    }
}
