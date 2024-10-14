using GAMF_ENG.Data;
using GAMF_ENG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GAMF_ENG.Controllers
{
    public class HomeController : Controller
    {
        private readonly GAMFDbContext _context;

        public HomeController(GAMFDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var _student = _context.Students.ToList();
            return View();
        }

    }
}
