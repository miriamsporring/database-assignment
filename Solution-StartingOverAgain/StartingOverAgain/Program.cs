using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StartingOverAgain.Contexts;
using StartingOverAgain.Menus;
using StartingOverAgain.Repositories;
using StartingOverAgain.Services;

namespace StartingOverAgain
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\nackademin\Databasteknik\database-assigment\database-assignment\Solution-StartingOverAgain\StartingOverAgain\Contexts\database_soa.mdf;Integrated Security=True;Connect Timeout=30"));

            // Repositories
            services.AddScoped<AddressRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<PricingUnitRepository>();
            services.AddScoped<ProductCategoryRepository>();
            services.AddScoped<ProductRepository>();

            // Services
            services.AddScoped<CustomerService>();
            services.AddScoped<ProductService>();

            // Menus
            services.AddScoped<CustomerMenu>();
            services.AddScoped<ProductMenu>();
            services.AddScoped<MainMenu>();

            var sp = services.BuildServiceProvider();
            var mainMenu = sp.GetRequiredService<MainMenu>();
            await mainMenu.StartAsync();

        }
    }

}