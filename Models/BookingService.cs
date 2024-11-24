namespace CarWashingManagementSystem.Models
{
    public class BookingService
    {
        public int BookingId { get; set; }
        public int ServiceId { get; set; }

        // Navigation properties
        public Booking Booking { get; set; }
        public Service Service { get; set; }
    }
}
