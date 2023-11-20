using SuperYarnCompany.Models;
using SuperYarnCompany.Repositories;
using SuperYarnCompany.Services;

namespace SuperYarnCompany.Menus;

internal class ProductMenu
{
    private readonly ProductService _productService;

    public ProductMenu(ProductService productService)
    {
        _productService = productService;
    }

    public async Task ManageProduct()
    {
        Console.Clear();
        Console.WriteLine("Product Menu");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. View all Products");
        Console.Write("Choose one Option");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await CreateAsync();
                break;


            case "2":
                await GetAllAscync();
                break;


        }

    }

    private Task GetAllAscync()
    {
        throw new NotImplementedException();
    }

    public async Task CreateAsync() 
    {
        var form = new ProductRegistrationForm();

        Console.Clear();
        Console.Write("Product Name: ");
        form.Name = Console.ReadLine()!;

        Console.Write("Product Description: ");
        form.Description = Console.ReadLine()!;

        Console.Write("Product Category: ");
        form.Category = Console.ReadLine()!;

        var result = await _productService.CreateProductAsync(form);
        if (result)
             Console.WriteLine("Product was created successfully");
        else 
            Console.WriteLine("Unable to create customer");
     }


















    // public virtual async Task GetAllAsync()
    //{
    //    Console.Clear();

    //    var products = await _productService.GetAllAsync();
    //    foreach (var product in products)
    //    {
    //        Console.WriteLine("Här ska alla visas");

    //    }

    //    Console.ReadKey();
    //}

}
