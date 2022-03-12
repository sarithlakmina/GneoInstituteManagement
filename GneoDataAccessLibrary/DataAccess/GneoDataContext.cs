using GneoCommonDataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GneoDataAccessLibrary.DataAccess
{
    public class GneoDataContext:DbContext
    {
        public GneoDataContext(DbContextOptions options) : base(options) { }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Course> Courses { get; set; }
        public  DbSet<Teacher> Teachers { get; set; }
    }
}
