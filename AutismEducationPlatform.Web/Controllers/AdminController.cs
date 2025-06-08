using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutismEducationPlatform.Web.Models;
using AutismEducationPlatform.Web.Models.ViewModels;
using System.Linq;

namespace AutismEducationPlatform.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var viewModel = new AdminDashboardViewModel
            {
                TotalUsers = 100,
                TotalCourses = 20,
                ActiveUsers = 80,
                Courses = new List<CourseViewModel>
                {
                    new CourseViewModel
                    {
                        Id = "1",
                        Title = "Temel İletişim Becerileri",
                        StudentCount = 5,
                        Status = "Aktif"
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult AddCourse()
        {
            return View();
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

        public IActionResult ManageUsers()
        {
            // Kullanıcı yönetimi sayfası
            return View();
        }

        public IActionResult SystemSettings()
        {
            // Sistem ayarları sayfası
            return View();
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction(nameof(Index));
        }
    }
} 