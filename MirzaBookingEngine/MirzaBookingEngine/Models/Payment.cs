using MirzaBookingEngine.AdditionalFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MirzaBookingEngine.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
                                              
        [Required]
        [RegularExpression(@"^(\d{13,19})$", ErrorMessage = "Credit card number should be 13 and 19(only numbers)")]
        public long CreditCardNumber { get; set; }

        [Required,MinLength(3), MaxLength(20)]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Only alphabets are allowed for NameOnCard field")]
        public string CardNumber { get; set; }

        [CheckDateRange]
        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [RegularExpression(@"^(\d{3,4})$", ErrorMessage = "CVV is usually 3 or 4 digit")]
        public int CVV { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}
