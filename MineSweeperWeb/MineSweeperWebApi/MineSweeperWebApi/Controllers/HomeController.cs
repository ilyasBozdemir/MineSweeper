using Microsoft.AspNetCore.Mvc;

namespace MineSweeperWebApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
