using Microsoft.AspNetCore.Mvc;

namespace ProjectTraversal.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
