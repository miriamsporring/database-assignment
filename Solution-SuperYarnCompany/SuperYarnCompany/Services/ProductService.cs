using Nest;
using SuperYarnCompany.Entities;
using SuperYarnCompany.Models;
using SuperYarnCompany.Repositories;

namespace SuperYarnCompany.Services;

internal class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryRepository _categoryRepository;

    public ProductService(CategoryRepository categoryRepository, ProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    // CREATE
    public async Task<bool> CreateProductAsync(ProductRegistrationForm form)
    {
        if (!await _productRepository.ExistsAsync(x => x.Name == form.Name))
        {
            //get or create category 
            var categoryEntity = await _categoryRepository.GetAsync(x => x.CategoryName == form.Name);
            categoryEntity ??= await _categoryRepository.CreateAsync(new CategoryEntity { CategoryName = form.Category });

            var productEntity = await _productRepository.CreateAsync(new ProductEntity()
            {
                Name = form.Name,
                Description = form.Description,
                Category = form.Category
            });


        }
        return true;


    }

}

    //internal Task<bool> CreateProductAsync(ProductRegistrationForm form)
    //{
    //    throw new NotImplementedException();
    //}





    // get or create product


    //if (!await _productRepository.ExistsAsync(x => x.Name == form.Name))

    //    // get or create customer type

    //{
    //    var productEntity = await _productRepository.GetAsync(new ProductEntity);
    //    productEntity = await _productRepository.CreateAsync(new ProductEntity { Name = form.Name, Description = form.Description, Category = form.Category });



    //}












    //public async Task<ProductEntity> CreateProductAsync(ProductEntity productEntity)
    //{
    //    //hämta eller skapa en kategori som vi kan lägga till på produkten  
    //    var categoryEntity = await _categoryRepository.GetAsync(x => x.CategoryName == productEntity.Category.CategoryName);
    //    categoryEntity ??= await _categoryRepository.CreateAsync(new CategoryEntity { CategoryName = productEntity.Category.CategoryName });

    //    // lägg till categoryEntity.Id till din productEntity
    //    productEntity.CategoryId = categoryEntity.Id;

    //    //create product
    //    return await _productRepository.CreateAsync(productEntity);

    //}

    //internal Task<bool> CreateProductAsync(ProductRegistrationForm form)
    //{
    //    throw new NotImplementedException();
    //}


//SE INSPELNING 15/11!!!

//public async Task<ProductEntity> GetCustomerAsync(string email) 
//{

//}

//public async Task<CustomerEntity> UpdateCustomerAsync(CustomerEntity customerEntity)
//{

//}

//public async Task<bool> DeleteCustomerAsync(string email)
//{

//}













