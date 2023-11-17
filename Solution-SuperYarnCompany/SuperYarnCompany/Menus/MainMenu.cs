namespace SuperYarnCompany.Menus;

internal class MainMenu
{
    private readonly CustomerMenu _customerMenu;
    private readonly ProductMenu _productMenu;

    public MainMenu(CustomerMenu customerMenu, ProductMenu productMenu)
    {
        _customerMenu = customerMenu;
        _productMenu = productMenu;
    }

    public async Task MainMenuAsync()

    {

        do
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Manage Customers");
            Console.WriteLine("2. Manage Products");
            Console.Write("Choose one Option");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await ManageCustomer();
                   break;

                case "2":
                    await ManageProduct();
                    break;

            }

        }
        while (true);
    }

    public async Task ManageCustomer()
    {
        Console.Clear();
        Console.WriteLine("Customer Menu");
        Console.WriteLine("1. Add Customer");
        Console.WriteLine("2. View Customer");
        Console.WriteLine("3. View All Customers");
        Console.WriteLine("4. Update Customer");
        Console.WriteLine("5. Delete Customer");
        Console.Write("Choose one Option");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await _customerMenu.CreateAsync();//ändra
                break;

            case "2":
                await ManageCustomer(); //await _customerMenu.GetAll(); när jag gjort getAll
                break;
        }    
       
    }


    public async Task ManageProduct()
    {
        Console.Clear();
        Console.WriteLine("Product Menu");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. View Product");
        Console.WriteLine("3. View All Products");
        Console.WriteLine("4. Update Product");
        Console.WriteLine("5. Delete Product");
        Console.Write("Choose one Option");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await _productMenu.CreateAsync();
                break;


            case "2":
                await ManageProduct();
                break;


        }

    }
}

