using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentGrades.BLL.DTOs;
using StudentGrades.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGrades.APP.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var students = await _studentService.GetStudentsAsync();
            return View(students);
        }

        [AllowAnonymous]
        public async Task<ActionResult> Statistics()
        {
            var stats = await _studentService.GetStudentStatisticsAsync();
            return View(stats);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(student);
                }
                await _studentService.InsertStudentAsync(student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateGrade()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateGrade(Grade grade)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(grade);
                }
                await _studentService.AddStudentGradeAsync(grade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                var students = await _studentService.GetStudentsAsync();
                if(!students.Any(s => s.Id == grade.OwnerId))
                {
                    ModelState.AddModelError("OwnerId", "Student not found");
                }
                return View();
            }
        }
    }
}
