using ModelStateTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelStateTesting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new AppointmentRequest());
        }

        [HttpPost]
        public ActionResult Index(AppointmentRequest model)
        {
            if (ModelState.IsValid)
            {
                // here we would save the appointment to a database
                return View("Confirmation", model);
            }
            else
            {
                // send them back to the entry form
                return View("Index", model);
            }
        }
    }
}