using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kleinandwolfeapi.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<OrderProduct> OrderProducts {get;set;}
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Promotion> Promotions {get;set;}
    public DbSet<PromotionOrder> PromotionOrders {get;set;}


    

  }

}