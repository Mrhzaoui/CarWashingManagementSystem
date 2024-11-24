using Microsoft.EntityFrameworkCore;
using CarWashingManagementSystem.Models;



    namespace CarWashingManagementSystem.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Booking> Bookings { get; set; }

            public DbSet<BookingService> BookingServices { get; set; }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Service> Services { get; set; }
            public DbSet<Payment> Payments { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Customer-Car Relationship (One-to-Many)
                modelBuilder.Entity<Car>()
                    .HasOne(c => c.Customer) // A Car belongs to one Customer
                    .WithMany(cu => cu.Cars) // A Customer can own many Cars
                    .HasForeignKey(c => c.CustomerId); // Foreign Key in the Car table

                // Booking-Customer Relationship (Many-to-One)
                modelBuilder.Entity<Booking>()
                    .HasOne(b => b.Customer)
                    .WithMany(cu => cu.Bookings)
                    .HasForeignKey(b => b.CustomerId);

                // Booking-Service Many-to-Many Relationship
                modelBuilder.Entity<BookingService>()
                    .HasKey(bs => new { bs.BookingId, bs.ServiceId });

                modelBuilder.Entity<BookingService>()
                    .HasOne(bs => bs.Booking)
                    .WithMany(b => b.BookingServices)  // Make sure 'BookingServices' is defined in the Booking model
                    .HasForeignKey(bs => bs.BookingId);

                modelBuilder.Entity<BookingService>()
                    .HasOne(bs => bs.Service)
                    .WithMany(s => s.BookingServices)
                    .HasForeignKey(bs => bs.ServiceId);
            }
        }
    }





