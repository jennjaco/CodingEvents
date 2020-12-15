using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
