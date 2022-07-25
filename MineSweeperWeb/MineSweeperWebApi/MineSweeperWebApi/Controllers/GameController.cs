using Microsoft.AspNetCore.Mvc;
using MineSweeperApp;

namespace MineSweeperWebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class GameController : Controller
    {

        //[HttpGet]
        MineSweeper mineSweeper = new(new Matrix(5,5));
       
    }
}
