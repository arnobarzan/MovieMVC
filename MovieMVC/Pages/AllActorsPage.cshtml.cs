using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieAppMVC.Models;

namespace MovieAppMVC.Pages
{
    public class AllActorsPageModel : PageModel
    {
        private IActorRepository _actorRepository;

        public List<Actor> Actors { get; set; }

        public AllActorsPageModel(IActorRepository repository)
        {
            _actorRepository = repository;
            Actors = new List<Actor>();
        }

        public IActionResult OnGet()
        {
            Actors = _actorRepository.AllActors.ToList();
            return Page();
        }
    }
}
