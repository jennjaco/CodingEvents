using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description of the event.")]
        [StringLength(500, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter a location for this event.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "How many people are expected to attend?")]
        [StringLength(100000)]
        public string Attendees { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public AddEventViewModel(List<EventCategory> categories)
        {
            Categories = new List<SelectListItem>();

            foreach (var category in categories)
            {
                Categories.Add(
                    new SelectListItem
                {
                    Value = category.Id.ToString(),
                    Text = category.Name
                }
                    ); 
            }
        }

        public AddEventViewModel() { }
    }
}
