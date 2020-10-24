using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("razor");
        }
        [HttpGet("HiThere")]
        public IActionResult Hello()
        {
            return View("hello");
        }

        [HttpGet("hello")]
        public IActionResult Any()
        {
            return RedirectToAction("Hello");
        }

        [HttpGet("hello/{username}/{location}")]
        public JsonResult Jsontest(string username, string location)
        {
            var response = new {user = username, place = location};
            return Json(response);
        }
    }
}