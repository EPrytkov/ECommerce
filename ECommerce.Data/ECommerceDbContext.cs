using ECommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;

public class ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : DbContext(options)
{
   public DbSet<Product> Products { get; set; }
   
   public DbSet<Order> Orders { get; set; }
   
   public DbSet<User> Users { get; set; }
   
   public DbSet<Category> Categories { get; set; }
}