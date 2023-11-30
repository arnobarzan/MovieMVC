using MovieAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MovieAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IActorRepository _actorRepository;

        public HomeController(ILogger<HomeController> logger,
            IActorRepository repo)
        {
            _logger = logger;
            _actorRepository = repo;
        }

        public IActionResult Index()
        {
            Actor? aotw = _actorRepository.ActorOfTheWeek;
            return View(aotw);
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
