using Microsoft.AspNetCore.Mvc;

namespace prj29bWebCoreMVC.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
