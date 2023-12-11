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

        public ViewResult AddActor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddActor(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _actorRepository.CreateActor(actor);
                return RedirectToAction("CreatedActor", actor);
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeleteActor(Guid id)
        {
            Actor? deletedActor = _actorRepository.DeleteActorById(id);
            if (deletedActor != null)
            {
                return View("DeletedActor", deletedActor);
            }

            return BadRequest("Actor not found");
        }

        public ViewResult CreatedActor(Actor actor)
        {
            return View(actor);
        }
    }
}
