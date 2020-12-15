using System;
using System.Collections.Generic;
using System.Linq;
using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CodingEvents.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<EventCategory> category = context.Category.ToList();

            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };

                context.Category.Add(newCategory);
                context.SaveChanges();

                return Redirect("/EventCategory"); 
            }
            return View("Create", addEventCategoryViewModel);

        }
    }
}
