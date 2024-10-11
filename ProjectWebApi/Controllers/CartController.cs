using Microsoft.AspNetCore.Mvc;

namespace ProjectWebApi.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
