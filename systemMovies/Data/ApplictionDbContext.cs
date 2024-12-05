using Microsoft.EntityFrameworkCore;
using systemMovies.Models;

namespace systemMovies.Data
{
    public class ApplictionDbContext : DbContext
    {
        public DbSet<Movie> Movies {  get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor> Actors  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ActorMovies> ActorMovies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MovieSystem;Integrated Security=True;" +
                "TrustServerCertificate=True");
        }
    }
}
