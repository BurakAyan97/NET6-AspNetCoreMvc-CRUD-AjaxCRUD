using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YoutubeProjectAJAX1.Controllers
{
    //[Authorize(Roles = "admin,manager")]
    [Authorize(Roles = "admin", AuthenticationSchemes = "Cookies")]
    public class AdminController : Controller
    {
        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
