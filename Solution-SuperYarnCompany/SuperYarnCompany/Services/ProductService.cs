using Microsoft.EntityFrameworkCore;
using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;
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

    public async Task<ProductEntity> CreateProductAsync(ProductEntity productEntity)
    {
        //hämta eller skapa en kategori som vi kan lägga till på produkten  
        var categoryEntity = await _categoryRepository.GetAsync(x => x.CategoryName == productEntity.Category.CategoryName);
        categoryEntity ??= await _categoryRepository.CreateAsync(new CategoryEntity { CategoryName = productEntity.Category.CategoryName });

        // lägg till categoryEntity.Id till din productEntity
        productEntity.CategoryId = categoryEntity.Id;

        //create product
        return await _productRepository.CreateAsync(productEntity);

    }


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

}











