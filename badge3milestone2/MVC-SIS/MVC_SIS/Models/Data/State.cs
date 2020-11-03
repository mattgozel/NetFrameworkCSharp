﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercises.Models.Data
{
    public class State
    {
        [Required(ErrorMessage = "Please enter the state abbreviation")]
        public string StateAbbreviation { get; set; }

        [Required(ErrorMessage = "Please enter the state name")]
        public string StateName { get; set; }
    }
}