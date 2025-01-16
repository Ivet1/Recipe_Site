using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recipe_Site.Models;
using System.Diagnostics;

namespace Recipe_Site.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            _logger.LogError("An error occurred with Request ID: {RequestId}", requestId); // Log error
            return View(new ErrorViewModel { RequestId = requestId });
        }
    }
}
