using System.ComponentModel.DataAnnotations;

namespace MovieAppMVC.Models
{
    public class Actor
    {
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must fill in a first name.")]
        [RegularExpression(@"^[A-Z]{1}[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "First name must start with a capital letter")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int BirthYear { get; set; }

        public string PictureUrl { get; set; }

    }
}
