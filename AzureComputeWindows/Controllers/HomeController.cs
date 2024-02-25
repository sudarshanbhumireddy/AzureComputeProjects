using AzureComputeWindows.DataAccess;
using AzureComputeWindows.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureComputeWindows.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDBContext _context;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger,AppDBContext appDBContext,IConfiguration config)
        {
            _logger = logger;
            _context = appDBContext;
            _config = config;
        }

        public IActionResult Index()
        {
            //var allCourses=_context.Courses.ToList();
            var allCourses= SqlHelper.GetAllCourses(_config.GetConnectionString("AzureConnection"));
            return View(allCourses);
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
