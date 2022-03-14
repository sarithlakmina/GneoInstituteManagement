using GneoDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private readonly GneoDataContext _context;

        public StudentController(GneoDataContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllStudents()
        {
           // var result = _context.Students.ToList();
            //return View(result);

            
            return View(await _context.Students.ToListAsync());

        }

        //GET : Students/AddEditStudent
        //GET : Students/AddEditStudent/5
        public async Task<IActionResult> AddEditStudent(int id=0)
        {
            if(id==0)
            {
                return View();
            }
            else
            {
                var AddEditStudentModel = await _context.Students.FindAsync(id);
                if(AddEditStudentModel ==null)
                {
                    return NotFound();
                }

                return View(AddEditStudentModel);
            }
           
        }
    }
}
