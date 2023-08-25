using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Assessment4.Models;

namespace Assessment4.Data{
    public class ApplicationDbContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer("Server=localhost; Database=Assessement; User id=SA; Password=S@ndrine1!; Encrypt=True; TrustServerCertificate=True");
        }
        public DbSet<User> Users {get; set; }
        public DbSet<Product> Products {get; set; }
        public DbSet<Order> Orders {get; set; }
        public DbSet<Shipment> Shipments {get; set; }
        public DbSet<Payment> Payments {get; set; }
        public DbSet<Cart> Carts {get; set; }
    }
}