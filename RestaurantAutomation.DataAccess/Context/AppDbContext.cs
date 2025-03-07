using Microsoft.EntityFrameworkCore;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Melek SQL String:
           // optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BPMLTJH\SQLEXPRESS;Initial Catalog=RestaurantAutomation;Integrated Security=True;Trust Server Certificate=True;");

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;;Initial Catalog=RestaurantAutomation;Integrated Security=True;Trust Server Certificate=True;");

            //ebru
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IAR6P2O;Initial Catalog=RestaurantAutomation;Integrated Security=True;Trust Server Certificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID);

            modelBuilder.Entity<OrderDetail>().HasKey(x =>
            new { x.OrderID, x.MenuItemID });
        }
    }


}
