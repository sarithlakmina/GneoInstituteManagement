﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoCommonDataLibrary.Models
{
    public class Teacher
    {
        public Guid TeacherID { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public string FullName { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public List<Course> CourseofTeacher { get; set; } = new List<Course>();
    }
}
