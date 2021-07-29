using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MirzaBookingEngine.ViewModels
{
    public class AdminViewModel
    {
        public string Property { get; set; } = "The Honor Motel";

        public string CustomerName { get; set; }

        public int ReservationId { get; set; }

        public int Adults { get; set; }

        public int Room { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int Nights { get; set; }



    }
}
