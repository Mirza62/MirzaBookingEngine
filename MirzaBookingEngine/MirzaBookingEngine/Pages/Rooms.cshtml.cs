using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MirzaBookingEngine.Models;

namespace MirzaBookingEngine.Pages
{
    public class RoomsModel : PageModel
    {
        private readonly BookingEngineDbContext context;

        public RoomsModel(BookingEngineDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Reservation> AllReservations { get; set; }

        public Reservation Reservation { get; set; }

        public IQueryable<Room> Rooms { get; set; }

        public void OnGet(Reservation reservation)
        {
            Reservation = reservation;
            Rooms = context.Room;
            if (Rooms != null)
            {
                AllReservations = context.Reservation;
                foreach (var room in Rooms)
                {
                    if (room.IsRoomAvailable == false)
                    {
                        var roomReservations = context.Reservation.Where(a => a.RoomId == room.RoomId).Select(b => new { b.CheckInDate, b.CheckOutDate })
                            .OrderByDescending(b => b.CheckInDate).ToList();
                        var count = 0;
                        foreach (var roomReservation in roomReservations)
                        {
                            if (Reservation.CheckInDate.Date < roomReservation.CheckInDate.Date && Reservation.CheckOutDate.Date < roomReservation.CheckInDate.Date ||
                                Reservation.CheckInDate.Date > roomReservation.CheckOutDate.Date && Reservation.CheckOutDate.Date > roomReservation.CheckOutDate.Date)
                            {
                                room.IsRoomAvailable = true;
                                count += 1;
                            }
                            if (count != roomReservations.Count)
                            {
                                room.IsRoomAvailable = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
