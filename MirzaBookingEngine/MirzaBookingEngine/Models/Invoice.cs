using System.Collections.Generic;

namespace MirzaBookingEngine.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public decimal Tax { get; set; }

        public decimal TotalStayPrice { get; set; }

        public decimal TotalRoomCost { get; set; }

        public IEnumerable<Reservation> Reservation { get; set; }
    }
}
