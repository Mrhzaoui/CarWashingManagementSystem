namespace CarWashingManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Relationships
        public ICollection<Car> Cars { get; set; } = new List<Car>(); // Updated to reference Cars
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
