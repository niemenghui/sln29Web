using Microsoft.AspNetCore.Mvc;

namespace prj29bWebCoreMVC.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Phone")]
        public string Phone()
        {
            return "+49-333-3333333";
        }
        [Route("country")]
        public string Country()
        {
            return "Germany811";
        }
    }
}