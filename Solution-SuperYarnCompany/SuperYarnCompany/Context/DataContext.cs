using Microsoft.EntityFrameworkCore;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Context;


internal class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<CustomerTypeEntity> CustomersTypes { get; set; }
    
        
}

