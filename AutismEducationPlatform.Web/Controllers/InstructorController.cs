using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutismEducationPlatform.Web.Models;
using AutismEducationPlatform.Web.Models.ViewModels;

namespace AutismEducationPlatform.Web.Controllers
{
    [Authorize(Roles = "Instructor")]
    public class InstructorController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public InstructorController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new InstructorDashboardViewModel
            {
                InstructorInfo = new InstructorInfo
                {
                    Name = user.UserName ?? "Belirtilmemiş",
                    Email = user.Email ?? "Belirtilmemiş",
                    Expertise = "Otizm Eğitimi" // Bu bilgi daha sonra veritabanından alınabilir
                },
                AssignedCourses = new List<CourseViewModel>
                {
                    new CourseViewModel
                    {
                        Id = "1",
                        Title = "Temel İletişim Becerileri",
                        StudentCount = 5,
                        Status = "Aktif"
                    }
                },
                StudentProgress = new List<StudentProgress>
                {
                    new StudentProgress
                    {
                        StudentName = "Ahmet Yılmaz",
                        CourseName = "Temel İletişim Becerileri",
                        ProgressPercentage = 75,
                        LastActivity = DateTime.Now.AddDays(-1),
                        StudentId = "1"
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult AddCourse()
        {
            return View(new CourseViewModel());
        }

        [HttpPost]
        public IActionResult AddCourse(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kurs ekleme işlemleri
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult EditCourse(int id)
        {
            // Kurs düzenleme sayfası
            return View();
        }

        public IActionResult DeleteCourse(int id)
        {
            // Kurs silme işlemleri
            return RedirectToAction(nameof(Index));
        }

        public IActionResult StudentList()
        {
            // Öğrenci listesi sayfası
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            // Geri bildirimler sayfası
            return View();
        }
    }
} 