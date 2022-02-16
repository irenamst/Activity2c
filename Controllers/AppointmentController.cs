using Activity2c.Models;

using Microsoft.AspNetCore.Mvc;

namespace Activity2c.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }
        public IActionResult Create()
        { 
            return View();
        }
        public IActionResult Details(AppointmentModel appointment)
        {
            appointments.Add(appointment);
            return View("Details",appointment);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
