using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _MovieContext { get; set; }

        public HomeController(MovieApplicationContext movie)
        {
            _MovieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        // Adding a new movie
        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Add(ar);
                _MovieContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();

                return View(ar);
            }
        }

        // List of movies
        public IActionResult MovieList()
        {
            var applications = _MovieContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(applications);

        }

        // Update a movie
        [HttpGet]
        public IActionResult Update(int applicationid)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();

            var application = _MovieContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("NewMovie", application);
        }

        [HttpPost]
        public IActionResult Update(ApplicationResponse ar)
        {
            _MovieContext.Update(ar);
            _MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        //Delete a movie
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = _MovieContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _MovieContext.Responses.Remove(ar);
            _MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}