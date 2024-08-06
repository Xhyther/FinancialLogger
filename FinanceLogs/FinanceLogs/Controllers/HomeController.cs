using FinanceLogs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FinanceLogs.Services;

namespace FinanceLogs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FServices _services;

        public HomeController(ILogger<HomeController> logger, FServices services)
        {
            _logger = logger;
            _services = services;
        }

        public IActionResult Index()
        {
            var summary = _services.GetFinancialSummary();
            return View(summary);
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
