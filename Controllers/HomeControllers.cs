using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("razor");
        }
    }
}