using System;
using System.Collections.Generic;

namespace CarWashingManagementSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime BookingDate { get; set; }

        // Navigation property to relate to the Customer
        public Customer Customer { get; set; }

        // Add the BookingServices navigation property (Many-to-Many relationship)
        public ICollection<BookingService> BookingServices { get; set; }
    }
}
