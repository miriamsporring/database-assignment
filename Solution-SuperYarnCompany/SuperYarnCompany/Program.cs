using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SuperYarnCompany.Context;
using SuperYarnCompany.Repositories;
using SuperYarnCompany.Services;
using static SuperYarnCompany.Repositories.ColorRepositiory;

namespace SuperYarnCompany;

internal class Program
{
    static async Task Main(string[] args)
    {

        var services = new ServiceCollection();
        services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\nackademin\Databasteknik\database-assigment\database-assignment\Solution-SuperYarnCompany\SuperYarnCompany\Context\database_superyarncompany.mdf;Integrated Security=True;Connect Timeout=30"));

        
        services.AddScoped<AddressRepository>(); 
        services.AddScoped<AddressService>();

        services.AddScoped<ColorRepository>();
 

        services.AddScoped<CustomerRepository>();
        services.AddScoped<CustomerService>();

        services.AddScoped<OrderrowRepository>();


        services.AddScoped<OrderRepository>();
        services.AddScoped<OrderService>();

        services.AddScoped<ProductRepository>();
        services.AddScoped<ProductService>();

        services.AddScoped<TypeRepository>();


        using var sp = services.BuildServiceProvider();

        var customerService = sp.GetRequiredService<CustomerService>();
        await customerService!.CreateCustomerMenuAsync(); 
    }

}
