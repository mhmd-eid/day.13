using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using systemMovies.Data;

namespace Movie_Point.Controllers
{
    public class MovieController : Controller
    {
        ApplictionDbContext context = new ApplictionDbContext();

        
        public IActionResult Index(int id)
        {
            var movie = context.Movies
                .Include(e => e.Cinema)
                .Include(e => e.Category)
                .Include(e => e.ActorMovies)
                .ThenInclude(am => am.Actor)
                .FirstOrDefault(m => m.Id == id);

            return View(movie);

        }



    }
}
