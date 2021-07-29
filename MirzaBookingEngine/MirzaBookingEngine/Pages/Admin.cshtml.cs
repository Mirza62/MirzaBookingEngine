using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MirzaBookingEngine.Models;
using MirzaBookingEngine.ViewModels;

namespace MirzaBookingEngine.Pages
{
    public class AdminModel : PageModel
    {
        private readonly BookingEngineDbContext dbcontext;

        public List<AdminViewModel> AllReservations = new List<AdminViewModel>();

        public AdminModel(BookingEngineDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void OnGet()
        {
            AllReservations = GetReservations();
        }

        public List<AdminViewModel> GetReservations()
        {
            var query = dbcontext.Customer.Join(dbcontext.Reservation,
                a => a.ReservationId, b => b.ReservationId,
                (a, b) => new AdminViewModel
                {
                    CustomerName = a.FirstName + "" + a.SecondName,
                    ReservationId = b.ReservationId,
                    Adults = b.NoOfAdults,
                    Room = b.RoomId,
                    CheckIn = b.CheckInDate,
                    CheckOut = b.CheckOutDate,
                    Nights = b.Nights
                }).ToList();
            return query;
        }
    }
}
