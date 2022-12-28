using Microsoft.AspNetCore.Mvc;
using prj29bWebCoreMVC.Models;
using System.Diagnostics;

namespace prj29bWebCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string String2()
        {
            return "String2 MVC 5 Application";
        }

        public ContentResult Content3()
        {
            return Content("Content3, World! this message is from Home Controller using the Action Result");
        }


        public ObjectResult ObjectResult4()
        {
            var employee = new Employee { ID = 1, Name = "Mark Upston" };
            return new ObjectResult(employee);
        }
    }
}