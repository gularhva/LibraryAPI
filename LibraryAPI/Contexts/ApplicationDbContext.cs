using LibraryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book>? Books { get; set; }
    public DbSet<Author>? Authors { get; set; }
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Booking>? Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}