using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using systemMovies.Data;
using systemMovies.Models;
using static Azure.Core.HttpHeader;

namespace systemMovies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplictionDbContext _appContext = new();

        public IActionResult Home(int id , string name)
        {
            var movies = _appContext.Movies.ToList(); 
            var cinemas = _appContext.Cinemas.ToList(); 
            var Categroys = _appContext.Categories.ToList();


            var namee = _appContext.Movies.Select(x => x.Name);

           




            ViewBag.Cinemas = cinemas;
            ViewBag.Categories = Categroys; 
            return View(movies);
        }


        public IActionResult Show(int id)
        {
            var category = _appContext.Categories.ToList().FirstOrDefault(c => c.Id == id);
          return View(category);
          
           
        }






        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
