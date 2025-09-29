using Microsoft.AspNetCore.Mvc;

namespace TerrenceDriveHubMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

