using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleLeaseApp.Models;
using VehicleLeaseApp;

namespace VehicleLeaseApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application helps manage vehicle leases.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Created by Mandiseli Mfeya.";
            return View();
        }
    }
}
