using System.ComponentModel.DataAnnotations;

namespace systemMovies.Models
{
    public class ActorMovies 
    {
        public int Id { get; set; }
        public int ActorsId { get; set; }
        public int MoviesId { get; set; }

        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

    }
}
