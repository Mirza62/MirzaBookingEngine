using System.Collections.Generic;

namespace MirzaBookingEngine.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomProperty { get; set; }

        public string   Description { get; set; }

        public decimal Price { get; set; }

        public bool  IsRoomAvailable{ get; set; }

        public IEnumerable<Reservation> Reservations { get; set; }
    }
}
