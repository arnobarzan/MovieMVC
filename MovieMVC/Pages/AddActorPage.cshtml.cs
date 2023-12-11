using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieAppMVC.Models;

namespace MovieAppMVC.Pages
{
    public class AddActorPageModel : PageModel
    {
        private IActorRepository _actorRepository;

        [BindProperty]
        public Actor ActorToAdd { get; set; }

        public AddActorPageModel(IActorRepository repository)
        {
            _actorRepository = repository;
            ActorToAdd = new Actor();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _actorRepository.CreateActor(ActorToAdd);
            return RedirectToPage("AllActorsPage"); 
        }
    }
}
