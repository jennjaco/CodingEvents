﻿using System;
using System.Collections.Generic;

namespace CodingEvents.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Event> events { get; set; }


        public EventCategory(string name)
        {
            Name = name;
        }

        public EventCategory()
        {
        }

    }
}
