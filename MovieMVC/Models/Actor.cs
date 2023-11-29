namespace MovieAppMVC.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int BirthYear { get; set; }

        public string PictureUrl { get; set; }

    }
}
