using SuperYarnCompany.Models;
using SuperYarnCompany.Services;

namespace SuperYarnCompany.Menus;

internal class CustomerMenu
{
    private readonly CustomerService _customerService;

    public CustomerMenu(CustomerService customerService)
    {
        _customerService = customerService;
    }


    public async Task CreateAsync()
    {
        var form = new CustomerRegistrationForm();

        Console.Clear();
        Console.Write("First Name: ");
        form.FirstName = Console.ReadLine()!;

        Console.Write("Last Name: ");
        form.LastName = Console.ReadLine()!;

        Console.Write("Customer Type: ");
        form.CustomerType = Console.ReadLine()!;

        Console.Write("Email: ");
        form.Email = Console.ReadLine()!;

        Console.Write("StreetName: ");
        form.StreetName = Console.ReadLine()!;

        Console.Write("StreetNumber: ");
        form.StreetNumber = Console.ReadLine()!;

        Console.Write("PostalCode: ");
        form.PostalCode = Console.ReadLine()!;

        Console.Write("City: ");
        form.City = Console.ReadLine()!;

        var result = await _customerService.CreateCustomerAsync(form);
        if (result)
            Console.WriteLine("Customer was created successfully");
        else Console.WriteLine("Unable to create customer");

    }
}


