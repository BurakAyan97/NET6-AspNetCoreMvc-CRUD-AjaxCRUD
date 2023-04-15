using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YoutubeProjectAJAX1.Models;

namespace YoutubeProjectAJAX1.Controllers
{
    [Authorize(AuthenticationSchemes = "Cookies")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //CookieAuth varsa birisi bu dosyayı get ile almak isterse üye olmak zorunda ve cookie key-value değerlerini bilmek zorunda.
        [HttpGet]
        public IActionResult GetData()
        {
            return Json(new { Name = "Murat", Surname = "Başeren" });
        }

        [HttpPost]
        public IActionResult PostData([FromBody] PostDataApiModel model)
        {
            return Json(new { Error = false, Message = "Success" });
        }
    }
}