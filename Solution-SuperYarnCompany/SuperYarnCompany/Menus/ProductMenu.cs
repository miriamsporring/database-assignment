using SuperYarnCompany.Models;
using SuperYarnCompany.Services;

namespace SuperYarnCompany.Menus;

internal class ProductMenu
{
    private readonly ProductService _productService;

    public ProductMenu(ProductService productService)
    {
        _productService = productService;
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

        var result = await _productService.CreateProductAsync(form);//här fastnar det
        if (result)
             Console.WriteLine("Product was created successfully");
        else Console.WriteLine("Unable to create customer");


    }
    
}