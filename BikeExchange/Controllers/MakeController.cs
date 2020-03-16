using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikeExchange.Models;
using BikeExchange.Data;
using Microsoft.AspNetCore.Authorization;

namespace BikeExchange.Controllers
{
    [Authorize(Roles ="Admin, Executive")]
    public class MakeController : Controller
    {
        //// make/bikes
        //[Route("Make")]
        //[Route("Make/Bikes")]
        //public IActionResult Bikes()
        //{
        //    Make make = new Make { Id = 1, Name = "Harley Davidson" };
        //    return View(make);

        //    //ContentResult cr = new ContentResult { Content = "Hello World!!!!" };
        //    //return cr;
        //}

        //[Route("make/bikes/{year:int:length(4)}/{month:int:range(1,13)}")]
        //public IActionResult ByYearMonth(int year, int month)
        //{
        //    return Content(year + " " + month);
        //}


        private readonly BikeDbContext mDbContext;

        public MakeController(BikeDbContext dbContext)
        {
            mDbContext = dbContext;
            mDbContext.GetType();
        }

        public IActionResult Index()
        {
            return View(mDbContext.Makes.ToList());
        }

        // HTTP Get Method (without specifying the route, default is GET)
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                mDbContext.Add(make);
                mDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = mDbContext.Makes.Find(id);
            if (make == null)
                return NotFound();

            mDbContext.Remove(make);
            mDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var make = mDbContext.Makes.Find(id);
            if (make == null)
                return NotFound();

            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                mDbContext.Update(make);
                mDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }
    }
}