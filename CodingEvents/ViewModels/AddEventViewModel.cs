﻿using System;
using System.ComponentModel.DataAnnotations;

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

    }
}
