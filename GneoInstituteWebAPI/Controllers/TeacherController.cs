using GneoDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoInstituteWebAPI.Controllers
{
    public class TeacherController : Controller
    {
        private readonly GneoDataContext _context;

        public TeacherController(GneoDataContext context)
        {
            this._context = context;
        }
        public IActionResult Teachers()
        {
            var result = _context.Teachers.ToList();
            return View(result);   //returning data to view
        }
    }
}
