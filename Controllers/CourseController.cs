using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;
namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model=Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            if(Repository.Applications.Any(x=>x.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","Bu kullanıcı daha önce başvuru yapmış.");
            }
            if(ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback",model);
            }
            return View();
        }
    }
}