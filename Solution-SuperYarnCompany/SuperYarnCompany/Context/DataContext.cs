using Microsoft.EntityFrameworkCore;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Context;


internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<OrderrowEntity> Orderrows { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TypeEntity> Types { get; set; }
    public DbSet<ColorEntity> Colors { get; set; }
        
}

