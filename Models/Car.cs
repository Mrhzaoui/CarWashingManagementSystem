namespace CarWashingManagementSystem.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
