﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public int? RatingId { get; set; }
        public string Title { get; set; }
    }
}
