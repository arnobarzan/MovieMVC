using Microsoft.EntityFrameworkCore;

namespace MovieAppMVC.Models
{
    public class MovieAppDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options) : base(options)
        { }

    }
}
