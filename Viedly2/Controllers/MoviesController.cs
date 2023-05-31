using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viedly2.Models;
using Viedly2.ViewModels;

namespace Viedly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie()
        //    {
        //        Name = "Shreck"
        //    };
        //    var customrs = new List<Customers>
        //    {
        //        new Customers{Name="Enas"},
        //    new Customers { Name = "Mohamed" }
        //    };

        //    var viewModel = new RandomMovieViewModel { 
            
        //    Movie= movie,
        //    Customers = customrs
            
        //    };


        //    //return View(movie);
        //    return View(viewModel);

        //}
        public ActionResult Edit(int id)   // write in url instead of random --> edit/1
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex , string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if(String.IsNullOrWhiteSpace(sortBy))
        //     {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageindex={0} &sortBy={1}",pageIndex,sortBy));
        //}
        //public ActionResult ByReleaseDate(int year, int month)   // write in url instead of random --> edit/1
        //{
        //    return Content(year + "/" + month);
        //}

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customers>
            {
                new Customers { Name = "Customer 1" },
                new Customers { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

    }
    

}