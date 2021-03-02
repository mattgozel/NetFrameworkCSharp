using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using IModelBinder = System.Web.Mvc.IModelBinder;

namespace CheckBoxHeaven.Models
{
    public class BirthdayPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}