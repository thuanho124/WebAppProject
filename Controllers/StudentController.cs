using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSys.Data;
using LibraryManagementSys.Models;

namespace LibraryManagementSys.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext _context;

        public StudentController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index(int? id)
        {
            
            var student = await _context.Students
                .Include(r => r.RentedBooks)
                    .ThenInclude(b => b.Book)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.StudentID == id);

            return View(student);
        }

    }
}
