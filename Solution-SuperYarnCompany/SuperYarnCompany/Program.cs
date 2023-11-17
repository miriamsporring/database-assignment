using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SuperYarnCompany.Context;
using SuperYarnCompany.Menus;
using SuperYarnCompany.Repositories;
using SuperYarnCompany.Services;

namespace SuperYarnCompany;

internal class Program
{
    static async Task Main(string[] args)
    {

        var services = new ServiceCollection();
        services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\nackademin\Databasteknik\database-assigment\database-assignment\Solution-SuperYarnCompany\SuperYarnCompany\Context\database_superyarncompany.mdf;Integrated Security=True;Connect Timeout=30"));
        
        // Repositories
        services.AddScoped<AddressRepository>(); 
        services.AddScoped<CustomerRepository>();
        services.AddScoped<ProductRepository>();
        services.AddScoped<CategoryRepository>();
        services.AddScoped<CustomerTypeRepository>();

        // Services
        services.AddScoped<CustomerService>();
        services.AddScoped<ProductService>();

        // Menus
        services.AddScoped<MainMenu>();
        services.AddScoped<CustomerMenu>();
        services.AddScoped<ProductMenu>();


        using var sp = services.BuildServiceProvider();


        var mainMenu = sp.GetRequiredService<MainMenu>(); //skickar programmet till startmenyn, FUNKAR NU
        await mainMenu.MainMenuAsync(); 

    }
}
