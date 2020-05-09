using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using devops_demo.Web.Models;
using devops_demo.Core.Contracts;

namespace devops_demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IImportantBusiness ImportantBusiness;
        readonly ICounterService CounterService;

        public HomeController(ILogger<HomeController> logger, IImportantBusiness importantBusiness, ICounterService counterService)
        {
            _logger = logger;
            ImportantBusiness = importantBusiness;
            CounterService = counterService;
        }

        public IActionResult Index()
        {
            CounterService.Increment();
            var count = CounterService.GetCount();
            var msg = ImportantBusiness.GetGreetingMessage();
            return View(new GreetingViewModel(msg.Message, count));
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
