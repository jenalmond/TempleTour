using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTour.Models;

namespace TempleTour.Controllers
{
    public class HomeController : Controller
    {

        private TempleTourContext dbContext { get; set; }

        public HomeController(TempleTourContext context)
        {

            dbContext = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpTime()
        {
            var appointments = dbContext.appointments
                .Where(x => x.Available == true)
                .OrderBy(x => x.TourID)
                .ToList();
            return View(appointments);
        }

        //needs to pass appointment time to sign up form
        [HttpGet]
        public IActionResult SignUpForm(Appointment tour)
        {
            ViewBag.appointments = dbContext.appointments
                .Where(x => x.TourID == tour.TourID)
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult SignUpForm(SignUpResponse sur)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(sur);
                dbContext.SaveChanges();
                return View("Index");
            }
            else
            {
                ViewBag.appointments = dbContext.appointments
                .Where(x => x.TourID == sur.Appointment.TourID)
                .ToList();
                return View(sur);
            }
        }

        [HttpGet]
        public IActionResult Appointments()
        {
            var appointments = dbContext.responses
                .Include(x => x.Appointment)
                .ToList();
            return View(appointments);
        }


        [HttpGet]
        public IActionResult Edit(int groupid)
        {
            ViewBag.majors = dbContext.appointments.ToList();
            var appointment = dbContext.responses.Single(x => x.GroupID == groupid);
            return View("SignUpForm", appointment);
        }

        [HttpPost]
        public IActionResult Edit(SignUpResponse updates)
        {
            dbContext.Update(updates);
            dbContext.SaveChanges();
            return RedirectToAction("Appointments");
        }

        [HttpGet]
        public IActionResult Delete(int groupid)
        {
            var appointment = dbContext.responses.Single(x => x.GroupID == groupid);
            return View(appointment);
        }

        [HttpPost]
        public IActionResult Delete(SignUpResponse delete)
        {
            dbContext.responses.Remove(delete);
            dbContext.SaveChanges();
            return RedirectToAction("Appointments");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
