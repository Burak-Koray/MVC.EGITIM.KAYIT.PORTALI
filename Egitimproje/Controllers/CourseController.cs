using Egitimproje.Models;
using Microsoft.AspNetCore.Mvc;

namespace Egitimproje.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index() 
        {
            var model = Repositrory.Applications;
            return View(model); 
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repositrory.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an application for you.");
            }

            if (ModelState.IsValid)
            {
                Repositrory.Add(model);
                return View("Feedback", model);
            }
            return View();
        }
    }
}
    