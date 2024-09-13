using System.Diagnostics;
using Lesson7.Models;
using Lesson7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IInMemoryToDoCollection _toDoCollection;

        public HomeController(IInMemoryToDoCollection toDoCollection, ILogger<HomeController> logger)
        {
            _logger = logger;
            _toDoCollection = toDoCollection;
        }

        public IActionResult Index()
        {
            return View(_toDoCollection.GetAll());
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
