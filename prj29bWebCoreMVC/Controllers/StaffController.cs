using Microsoft.AspNetCore.Mvc;
using prj29bWebCoreMVC.Models;

namespace prj29bWebCoreMVC.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index99()
        {
            return View();
        }

        public ViewResult List()
        {
            var employee = new Employee { ID = 1, Name = "Mark Upston" };
            return View(employee);
        }
    }
}

