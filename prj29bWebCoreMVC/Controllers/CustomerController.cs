using Microsoft.AspNetCore.Mvc;

namespace prj29bWebCoreMVC.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        public string Phone()
        {
            return "+49-333-3333333";
        }
        [Route("country")]
        public string Country()
        {
            return "Germany";
        }
    }
}