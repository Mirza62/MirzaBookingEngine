using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MirzaBookingEngine.Models;
using System.Text.Json;

namespace MirzaBookingEngine.Pages
{
    public class BookRoomModel : PageModel
    {
        private readonly BookingEngineDbContext dbcontext;

        public BookRoomModel(BookingEngineDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public Customer Customer { get; set; } = new Customer();
        public Payment Payment { get; set; } = new Payment();
        public Reservation Reservation { get; set; }
        public Room Room { get; set; }
        public Invoice Invoice { get; set; }

        public void OnGet(string reservation, string room,string invoice)
        {
            Reservation = JsonSerializer.Deserialize<Reservation>(reservation);
            Room = JsonSerializer.Deserialize<Room>(room);
            Invoice = JsonSerializer.Deserialize<Invoice>(invoice);
        }


        public async Task<IActionResult> OnPost(string reservation, string room, string invoice, Customer customer,Payment payment)
        {
            Reservation = JsonSerializer.Deserialize<Reservation>(reservation);
            Room = JsonSerializer.Deserialize<Room>(room);
            Invoice = JsonSerializer.Deserialize<Invoice>(invoice);


            var selectedRoom = dbcontext.Room.Where(a => a.RoomId == Room.RoomId).FirstOrDefault();
            selectedRoom.IsRoomAvailable = false;
            dbcontext.Room.Update(selectedRoom);

            Payment p1 = payment;
            Customer c1 = customer;
            if (ModelState.IsValid)
            {
                dbcontext.Customer.AddRange(
                        new Customer()
                        {
                            FirstName = c1.FirstName,
                            SecondName = c1.SecondName,
                            Email = c1.Email,
                            PhoneNumber = c1.PhoneNumber,
                            Payment = p1,
                            Address = c1.Address,
                            Country = c1.Country,
                            State = c1.State,
                            City = c1.City,
                            Pincode = c1.Pincode,
                            Reservation = new Reservation
                            {
                                CheckInDate = Reservation.CheckInDate,
                                CheckOutDate = Reservation.CheckOutDate,
                                Nights = Reservation.Nights,
                                NoOfAdults = Reservation.NoOfAdults,
                                RoomId = Room.RoomId,
                                Invoice = Invoice
                            }
                        }
                    );
                try
                {
                    await dbcontext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return RedirectToPage("ExceptionHandle");
                }
                return RedirectToPage("CompletedBooking", new { FirstName = customer.FirstName , RoomNo = Room.RoomId});
            }
            else
            {
                return Page();
            }
        }
    }
}
