using System.ComponentModel.DataAnnotations;

namespace MirzaBookingEngine.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required, MinLength(2),MaxLength(20)]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Only alphabets are allowed for first name")]
        public string FirstName { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Only alphabets are allowed for first name")]
        public string SecondName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "The field Home Address is required")]
        [MinLength(3), MaxLength(200)]
        public string Address { get; set; }


        public string Country { get; set; }

        public string State { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Only alphabets are allowed for City field")]
        public string City { get; set; }

        [RegularExpression(@"^(\d{6})$", ErrorMessage = "Zipcode should be 6 digits")]
        [Required]
        public int Pincode { get; set; }

        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public int PaymentId { get; set; }

        public Payment Payment { get; set; }
    }
}
