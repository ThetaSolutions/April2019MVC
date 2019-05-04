using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMS.Models;

namespace MMS.Controllers
{
    public class MainController : Controller
    {
        private april2019dbContext ORM = null;
        public MainController(april2019dbContext _ORM)
        {
            int a = 10;
            ORM = _ORM;
        }


        public IActionResult Index()
        {
            
            return View();
        }

         [HttpGet]
        public IActionResult AddNewMovie()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddNewMovie(Movie M)
        {
            try
            {
                ORM.Movie.Add(M);
                ORM.SaveChanges();
                ViewBag.Message = "Movie is added successfuly";
            }
            catch(Exception ex)
            {
                ViewBag.Message = "An error occured, please try again";
            }

            return View();
        }


        public IActionResult ShowAllMovies()
        { 
            return View(ORM.Movie.ToList());
        }



    }
}