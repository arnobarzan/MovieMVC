using Microsoft.AspNetCore.Mvc;
using MovieAppMVC.Models;

namespace MovieAppMVC.Controllers
{
    public class ActorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IActorRepository _actorRepository;
        public ActorController(ILogger<HomeController> logger, IActorRepository repo)
        {
            _logger = logger;
            _actorRepository = repo;
        }
        public ViewResult Index()
        {
            return View(_actorRepository.AllActors);
        }
    }
}
