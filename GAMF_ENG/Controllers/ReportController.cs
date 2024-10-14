using GAMF_ENG.Data;
using GAMF_ENG.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAMF_ENG.Controllers
{
    public class ReportController : Controller
    {
        private readonly GAMFDbContext _context;

        public ReportController (GAMFDbContext context)
        {
            _context = context 
                ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()
        {
            var result = _context.Students.GroupBy(s => s.EnrollmentDate).
                Select(s => new EnrollmentDateVM
                {
                    EnrollmentDate = s.Key,
                    StudentCount = s.Count()
                });
            
            /* SQL ->
             select EnrollmentDate, count(*) from Students
             group by EnrollmentDate
             */

            return View(result.ToList());
        }
    }
}
