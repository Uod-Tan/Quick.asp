using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_TRY.Models;

namespace WebApplication_TRY.Controllers
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
            var studentInfoArray = new[]
       {
            new StudentInfoModel { Name = "John Doe", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Jane Smith", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Mike Johnson", StudentId = "S003", StudentAge = "31" }
        };

            return View(studentInfoArray);
        }
    

        public IActionResult About()
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