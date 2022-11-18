using Microsoft.AspNetCore.Mvc;

namespace MVCEjercicio4.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
