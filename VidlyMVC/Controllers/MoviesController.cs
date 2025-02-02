﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC.Models;
using VidlyMVC.ViewModel;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
             var movie = new Movie() {Name = "Shrek!" };

            //var movie = new List<Movie>
            //{ 
            //    new Movie { Name = "Shrek!"},
            //    new Movie { Name = "Walle"}
            //}
           

            var customers = new List<Customer>
            {
                 new Customer { Name = "Customer 1"},
                 new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

                  return View(viewModel);

            //  return Content("Hello World!");
            //  return HttpNotFound();
            //  return new EmptyResult();
            //  return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


        // movies/edit/1
        //public ActionResult Edit(int id) 
        //{
        //    return Content("id = " + id);
        //}



        //public ActionResult Index(int? pageIndex, string sortBy) 
        //{ 
        //    if(!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}




        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}