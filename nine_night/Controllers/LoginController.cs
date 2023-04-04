using Microsoft.AspNetCore.Mvc;

namespace nine_night.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
