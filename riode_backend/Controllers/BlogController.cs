using Microsoft.AspNetCore.Mvc;

namespace riode_backend.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
