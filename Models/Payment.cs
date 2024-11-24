using CarWashingManagementSystem.Models;

namespace CarWashingManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        // Navigation property
        public Booking Booking { get; set; }
    }
}
