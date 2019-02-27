using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAPP.DatabaseContext;
using MVCAPP.Models;

namespace MVCAPP.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Student aStudent)
        {
            if (ModelState.IsValid)
            {
                StudentDbContext db=new StudentDbContext();
                db.Students.Add(aStudent);
                db.SaveChanges();
            }

            return View();
        }
    }
}