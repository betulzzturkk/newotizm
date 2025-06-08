using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using AutismEducationPlatform.Web.Models;
using AutismEducationPlatform.Web.Models.ViewModels;
using System.Text.Json;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace AutismEducationPlatform.Web.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ParentController(UserManager<IdentityUser> userManager)
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

            var viewModel = new ParentDashboardViewModel
            {
                ChildInfo = new ChildInfo
                {
                    Name = "Ali Yılmaz",
                    Age = 8,
                    Diagnosis = "Otizm Spektrum Bozukluğu"
                },
                Courses = new List<CourseViewModel>
                {
                    new CourseViewModel
                    {
                        Id = "1",
                        Title = "Temel İletişim Becerileri",
                        StudentCount = 5,
                        Status = "Aktif"
                    }
                },
                ProgressReport = new ProgressReport
                {
                    Title = "Haftalık İlerleme Raporu",
                    Content = "Bu hafta iletişim becerilerinde önemli gelişmeler kaydedildi.",
                    Date = DateTime.Now.AddDays(-1)
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ToggleChildMode()
        {
            // Çocuk/Veli modu geçiş işlemleri
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Progress()
        {
            // İlerleme raporu sayfası
            return View();
        }

        public IActionResult ChildInfo()
        {
            // Çocuk bilgileri sayfası
            return View();
        }

        public IActionResult Courses()
        {
            // Kurslar sayfası
            return View();
        }

        public IActionResult Information()
        {
            // Bilgilendirmeler sayfası
            return View();
        }

        public IActionResult Feedback()
        {
            // Geri bildirimler sayfası
            return View();
        }
    }
} 