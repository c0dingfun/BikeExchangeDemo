using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeExchange.Data;
using BikeExchange.Models;
using BikeExchange.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeExchange.Controllers
{
    public class ModelController : Controller
    {
        private readonly BikeDbContext mDbContext;

        [BindProperty] // HH: instruct Model Binding to bind to this property
        public ModelViewModel ModelViewModel { get; set; }

        public ModelController(BikeDbContext dbContext)
        {
            mDbContext = dbContext;
            ModelViewModel = new ModelViewModel
            {
                Makes = mDbContext.Makes.ToList(),
                Model = new Models.Model()
            };
        }

        public IActionResult Index()
        {
            // eager loading
            var model = mDbContext.Models.Include(m => m.Make);
            return View(model);
        }

        // HTTP GET
        public IActionResult Create()
        {
            return View(ModelViewModel);
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelViewModel);
            }

            mDbContext.Add(ModelViewModel.Model);
            mDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            // HH: retrieve from DB
            ModelViewModel.Model =
                mDbContext.Models   // retrieve Models
                          .Include(m => m.Make) // also include their Make
                          .SingleOrDefault(m => m.Id == id);    // only for Model with id

            if (ModelViewModel.Model == null)   // HH: check if Model found
            {
                return NotFound();
            }

            return View(ModelViewModel);
        }


        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelViewModel);
            }

            mDbContext.Update(ModelViewModel.Model);
            mDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost] // HH: we do delete via post, NOT GET!!!
        public IActionResult Delete(int id) // HH: model id
        {
            //Model model = mDbContext.Models.Where(model => model.Id == id).FirstOrDefault(); ;
            Model model = mDbContext.Models.Find(id);
            if (model == null)
            {
                return NotFound();
            }

            mDbContext.Remove(model);
            mDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}