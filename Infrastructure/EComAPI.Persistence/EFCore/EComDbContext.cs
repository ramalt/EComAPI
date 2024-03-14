using EComAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EComAPI.Persistence.EFCore;

public class EComDbContext : DbContext
{
    public EComDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
