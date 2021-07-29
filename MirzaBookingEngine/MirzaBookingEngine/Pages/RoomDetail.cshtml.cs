using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MirzaBookingEngine.Models;

namespace MirzaBookingEngine.Pages
{
    public class RoomDetailModel : PageModel
    {
        private readonly BookingEngineDbContext dbcontext;

        public RoomDetailModel(BookingEngineDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        } 

        public Room Room { get; set; }

        public Reservation Reservation { get; set; }

        public Invoice Invoice { get; set; } = new Invoice();

        public void OnGet(int roomId,string reservation)
        {
            Room = dbcontext.Room.Where(a => a.RoomId == roomId).FirstOrDefault();
            Reservation = JsonSerializer.Deserialize<Reservation>(reservation);
            Reservation.RoomId = roomId;
            Reservation.Nights = Reservation.CheckInDate.Date != Reservation.CheckOutDate.Date ? (int)(Reservation.CheckOutDate - Reservation.CheckInDate).TotalDays : 1;
            Invoice.TotalStayPrice = Reservation.Nights * Room.Price;
            Invoice.Tax = 0.18m * Invoice.TotalStayPrice;
            Invoice.TotalRoomCost = Invoice.Tax + Invoice.TotalStayPrice;
            Reservation.InvoiceId = Invoice.InvoiceId;
        }
    }
}
