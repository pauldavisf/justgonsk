﻿using System;
using System.Collections.Generic;
using JustGo.Models;

namespace JustGo.View.Models
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BodyText { get; set; } // полное описание
        public string Address { get; set; }
        public Place Place { get; set; } // место проведения
        public List<string> Categories { get; set; } // список категорий
        public List<string> Tags { get; set; }
        public List<string> ImageURLs { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
