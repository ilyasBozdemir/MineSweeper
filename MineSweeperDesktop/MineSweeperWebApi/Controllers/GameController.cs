using Microsoft.AspNetCore.Mvc;
namespace MineSweeperWebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class GameController : Controller
    {

        //[HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
