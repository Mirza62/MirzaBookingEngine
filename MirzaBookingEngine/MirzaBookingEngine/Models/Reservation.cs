using MirzaBookingEngine.AdditionalFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MirzaBookingEngine.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [Required,CheckDateRange]
        public DateTime CheckInDate { get; set; }

        [Required, CheckDateRange]
        public DateTime CheckOutDate { get; set; }

        public int Nights { get; set; }

        [Range(1, 5, ErrorMessage = "Value must be in between 1 and 5")]
        public int NoOfAdults { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}
