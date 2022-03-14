using GneoDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoWebAPI.Controllers
{
    public class CourseController : Controller
    {
        private readonly GneoDataContext _context;

        public CourseController(GneoDataContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllCourses()
        {

            return View(await _context.Courses.ToListAsync());
        }

        public async Task<IActionResult> AddEditCourse(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                var AddEditCourseModel = await _context.Courses.FindAsync(id);
                if (AddEditCourseModel == null)
                {
                    return NotFound();
                }

                return View(AddEditCourseModel);
            }

        }
    }
}
