using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForumApp.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (TempData.ContainsKey("LastAccessTime"))
            {
                return Ok(TempData["LastAccessTime"]);
            }
            
            TempData["LastAccessTime"] = DateTime.Now;
            this.HttpContext.Response.Cookies.Append("firstCookie","Amazun.takingData.iso");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}