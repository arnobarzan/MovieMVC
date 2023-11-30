using Microsoft.EntityFrameworkCore;

namespace MovieAppMVC.Models
{
    public class MovieAppDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Actor a = new Actor();
            a.FirstName = "Tom";
            a.LastName = "Hanks";
            a.BirthYear = 1958;
            a.PictureUrl = "https://img.nieuwsblad.be/RNwKqDZsywgB1myZuQ3M4vyvSIM=/960x640/smart/https%3A%2F%2Fstatic.nieuwsblad.be%2FAssets%2FImages_Upload%2F2022%2F06%2F16%2F7e1e5207-0f92-4a05-bb3f-e3ba50555248.jpg";
            a.Id = new Guid("5a0c28db-6307-431b-b9d8-4b1701bd62f6");

            modelBuilder.Entity<Actor>().HasData(a);

            base.OnModelCreating(modelBuilder);
        }

    }
}
