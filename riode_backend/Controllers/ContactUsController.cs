using Microsoft.AspNetCore.Mvc;

namespace riode_backend.Controllers
{
	public class ContactUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
