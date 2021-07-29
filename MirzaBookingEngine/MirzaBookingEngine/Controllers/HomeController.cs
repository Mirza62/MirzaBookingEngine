using Microsoft.AspNetCore.Mvc;
using MirzaBookingEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MirzaBookingEngine.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookingEngineDbContext _dbContext;

        public HomeController(BookingEngineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Reservation reservation)
        {
            if (ModelState.IsValid && reservation.CheckOutDate >= reservation.CheckInDate)
            {
                return RedirectToPage("/Rooms", reservation);
            }
            else
            {
                return View();
            }
        }
    }
}
